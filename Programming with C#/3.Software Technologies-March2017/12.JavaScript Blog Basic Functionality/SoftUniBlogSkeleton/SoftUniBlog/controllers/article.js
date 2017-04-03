const Article = require('mongoose').model('Article');

module.exports = {
    createGet: (req, res) => {
        res. render('article/create');
    },
    createPost: (req, res) => {
        let articleParts = req.body;
        let errorMsg = '';

        if(!req.isAuthenticated()){
            errorMsg = 'Sorry, you must be logged in!';
        } else if(!articleParts.title) {
            errorMsg = 'Title is required';
        } else if(!articleParts.content) {
            errorMsg = 'Content is required';
        }

        if(errorMsg) {
            res.render('article/create', {error: errorMsg});
            return;
        }

        let userId = req.user.id;
        articleParts.author = userId;

        Article.create(articleParts).then(article => {
            req.user.articles.push(article.id);
            req.user.save(err => {
                if(err){
                    res.render('article/create', {error: errorMsg});
                } else {
                    res.redirect('/');
                }

            });
        })

    },
    detailsGet: (req, res) => {
        let id = req.params.id;
        Article.findById(id).populate('author').then(article => {
            res.render('article/details', article);
        });
    },

    editGet: (req, res) => {
        let id = req.params.id;
        Article.findById(id).then(article => {
            if((req.user === undefined) || !req.user.isAuthor(article)){
                res.render('home/index', {error: 'You cannot edit this article'});
                return;
            }
            res.render('article/edit', article);
        });
    },
    editPost: (req, res) => {
        let id = req.params.id;
        let articleParts = req.body;
        let errorMsg = '';
        if(!articleParts.title) {
            errorMsg = 'Title is required';
        } else if(!articleParts.content) {
            errorMsg = 'Content is required';
        }

        if(errorMsg) {
            res.render('article/edit', {error: errorMsg});
            return;
        }

        Article.update({_id: id}, {
                $set: {
                    title: articleParts.title,
                    content: articleParts.content
                }
            }).then(err => {
                    res.redirect('/');
            });

    },

    deleteGet: (req, res) => {
        let id = req.params.id;
        Article.findById(id).then(article => {
           res.render('article/delete', article);
        });
    },
    deletePost: (req, res) => {
        let id = req.params.id;
        Article.findOneAndRemove({_id: id}).populate('author').then(article => {
            let author = article.author;
            let index = author.articles.indexOf(article.id);
            if(index < 0) {
                let errorMsg = 'Article was not found for that author!';
                res.render('article/delete', {error: errorMsg})
            } else {
                let count = 1;
                author.articles.splice(index, count);
                author.save().then((user) => {
                    res. redirect('/');
                });
            }

        })
    }
};

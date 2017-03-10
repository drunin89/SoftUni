<?php

/* base.html.twig */
class __TwigTemplate_6fc1001059d28b9e6d6b5055e7f57bab6d81bd11639e16e6067edde36d6a9aa4 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'header' => array($this, 'block_header'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
            'javascripts' => array($this, 'block_javascripts'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_e460658e6759d6649451ccc2d1b6dfa96aa14dacbee8fbafdde92f442762ae4b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e460658e6759d6649451ccc2d1b6dfa96aa14dacbee8fbafdde92f442762ae4b->enter($__internal_e460658e6759d6649451ccc2d1b6dfa96aa14dacbee8fbafdde92f442762ae4b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>";
        // line 11
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 12
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 16
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 19
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">

";
        // line 21
        $this->displayBlock('header', $context, $blocks);
        // line 39
        echo "
<div class=\"container body-container\">
    ";
        // line 41
        $this->displayBlock('body', $context, $blocks);
        // line 48
        echo "</div>


";
        // line 51
        $this->displayBlock('javascripts', $context, $blocks);
        // line 57
        echo "
</body>
</html>
";
        
        $__internal_e460658e6759d6649451ccc2d1b6dfa96aa14dacbee8fbafdde92f442762ae4b->leave($__internal_e460658e6759d6649451ccc2d1b6dfa96aa14dacbee8fbafdde92f442762ae4b_prof);

    }

    // line 11
    public function block_title($context, array $blocks = array())
    {
        $__internal_4c61c5cfa6f2010f59d7c45b3816f16666dbb2d85e84a7bc48735a624d8ef850 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_4c61c5cfa6f2010f59d7c45b3816f16666dbb2d85e84a7bc48735a624d8ef850->enter($__internal_4c61c5cfa6f2010f59d7c45b3816f16666dbb2d85e84a7bc48735a624d8ef850_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Calculator";
        
        $__internal_4c61c5cfa6f2010f59d7c45b3816f16666dbb2d85e84a7bc48735a624d8ef850->leave($__internal_4c61c5cfa6f2010f59d7c45b3816f16666dbb2d85e84a7bc48735a624d8ef850_prof);

    }

    // line 12
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_9a64ead3abe819585f38d593becad848e9427a376a2847e05240a240a6834f79 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_9a64ead3abe819585f38d593becad848e9427a376a2847e05240a240a6834f79->enter($__internal_9a64ead3abe819585f38d593becad848e9427a376a2847e05240a240a6834f79_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 13
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/bootstrap-datetimepicker.min.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_9a64ead3abe819585f38d593becad848e9427a376a2847e05240a240a6834f79->leave($__internal_9a64ead3abe819585f38d593becad848e9427a376a2847e05240a240a6834f79_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_829f2b9490c696d2a90d5d7292a94bae6136626c257cd3c492ec0a3cbfa05e6a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_829f2b9490c696d2a90d5d7292a94bae6136626c257cd3c492ec0a3cbfa05e6a->enter($__internal_829f2b9490c696d2a90d5d7292a94bae6136626c257cd3c492ec0a3cbfa05e6a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_829f2b9490c696d2a90d5d7292a94bae6136626c257cd3c492ec0a3cbfa05e6a->leave($__internal_829f2b9490c696d2a90d5d7292a94bae6136626c257cd3c492ec0a3cbfa05e6a_prof);

    }

    // line 21
    public function block_header($context, array $blocks = array())
    {
        $__internal_dbc17dd5cf16e5cbaabc6305c91431aa7b8009bce7a177bc889f9013c7c6255c = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_dbc17dd5cf16e5cbaabc6305c91431aa7b8009bce7a177bc889f9013c7c6255c->enter($__internal_dbc17dd5cf16e5cbaabc6305c91431aa7b8009bce7a177bc889f9013c7c6255c_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "header"));

        // line 22
        echo "    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"";
        // line 26
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("index");
        echo "\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
";
        
        $__internal_dbc17dd5cf16e5cbaabc6305c91431aa7b8009bce7a177bc889f9013c7c6255c->leave($__internal_dbc17dd5cf16e5cbaabc6305c91431aa7b8009bce7a177bc889f9013c7c6255c_prof);

    }

    // line 41
    public function block_body($context, array $blocks = array())
    {
        $__internal_c22b5b64073fce464aa15966073a0683b0f05cd8853bf7653529b2645d33f9fa = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c22b5b64073fce464aa15966073a0683b0f05cd8853bf7653529b2645d33f9fa->enter($__internal_c22b5b64073fce464aa15966073a0683b0f05cd8853bf7653529b2645d33f9fa_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 42
        echo "        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                ";
        // line 44
        $this->displayBlock('main', $context, $blocks);
        // line 45
        echo "            </div>
        </div>
    ";
        
        $__internal_c22b5b64073fce464aa15966073a0683b0f05cd8853bf7653529b2645d33f9fa->leave($__internal_c22b5b64073fce464aa15966073a0683b0f05cd8853bf7653529b2645d33f9fa_prof);

    }

    // line 44
    public function block_main($context, array $blocks = array())
    {
        $__internal_b2a6b1ad03f9dac548acada0bd19e58224bcb18a8475788072159fc363ac5bc6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b2a6b1ad03f9dac548acada0bd19e58224bcb18a8475788072159fc363ac5bc6->enter($__internal_b2a6b1ad03f9dac548acada0bd19e58224bcb18a8475788072159fc363ac5bc6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_b2a6b1ad03f9dac548acada0bd19e58224bcb18a8475788072159fc363ac5bc6->leave($__internal_b2a6b1ad03f9dac548acada0bd19e58224bcb18a8475788072159fc363ac5bc6_prof);

    }

    // line 51
    public function block_javascripts($context, array $blocks = array())
    {
        $__internal_5d6c2352647b3c4d991ba41c453e19e2c4a2ec65eaa3683ac3a40aae3f0fb6e4 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_5d6c2352647b3c4d991ba41c453e19e2c4a2ec65eaa3683ac3a40aae3f0fb6e4->enter($__internal_5d6c2352647b3c4d991ba41c453e19e2c4a2ec65eaa3683ac3a40aae3f0fb6e4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "javascripts"));

        // line 52
        echo "    <script src=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/jquery-2.2.4.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 53
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/moment.min.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 54
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap.js"), "html", null, true);
        echo "\"></script>
    <script src=\"";
        // line 55
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("js/bootstrap-datetimepicker.min.js"), "html", null, true);
        echo "\"></script>
";
        
        $__internal_5d6c2352647b3c4d991ba41c453e19e2c4a2ec65eaa3683ac3a40aae3f0fb6e4->leave($__internal_5d6c2352647b3c4d991ba41c453e19e2c4a2ec65eaa3683ac3a40aae3f0fb6e4_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  205 => 55,  201 => 54,  197 => 53,  192 => 52,  186 => 51,  175 => 44,  166 => 45,  164 => 44,  160 => 42,  154 => 41,  134 => 26,  128 => 22,  122 => 21,  111 => 19,  102 => 14,  97 => 13,  91 => 12,  79 => 11,  69 => 57,  67 => 51,  62 => 48,  60 => 41,  56 => 39,  54 => 21,  49 => 19,  42 => 16,  40 => 12,  36 => 11,  29 => 6,);
    }

    public function getSource()
    {
        return "{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"/>
    <title>{% block title %}Calculator{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/bootstrap-datetimepicker.min.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">

{% block header %}
    <header>
        <div class=\"navbar navbar-default navbar-static-top\" role=\"navigation\">
            <div class=\"container\">
                <div class=\"navbar-header\">
                    <a href=\"{{ path('index') }}\" class=\"navbar-brand\">CALCULATOR</a>

                    <button type=\"button\" class=\"navbar-toggle\" data-toggle=\"collapse\" data-target=\".navbar-collapse\">
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                        <span class=\"icon-bar\"></span>
                    </button>
                </div>

            </div>
        </div>
    </header>
{% endblock %}

<div class=\"container body-container\">
    {% block body %}
        <div class=\"row\">
            <div id=\"main\" class=\"col-sm-9\">
                {% block main %}{% endblock %}
            </div>
        </div>
    {% endblock %}
</div>


{% block javascripts %}
    <script src=\"{{ asset('js/jquery-2.2.4.min.js') }}\"></script>
    <script src=\"{{ asset('js/moment.min.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap.js') }}\"></script>
    <script src=\"{{ asset('js/bootstrap-datetimepicker.min.js') }}\"></script>
{% endblock %}

</body>
</html>
";
    }
}

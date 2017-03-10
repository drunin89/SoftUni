<?php

/* @Twig/Exception/exception_full.html.twig */
class __TwigTemplate_94e968e736d877274de4c4c5db7f83ad99b642df2dc998073f352a2344d645a8 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@Twig/layout.html.twig", "@Twig/Exception/exception_full.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'title' => array($this, 'block_title'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@Twig/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_4c31844f2d6350fccb0612738f5dd7942047dd599544097e3d88f0c1224b5fea = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_4c31844f2d6350fccb0612738f5dd7942047dd599544097e3d88f0c1224b5fea->enter($__internal_4c31844f2d6350fccb0612738f5dd7942047dd599544097e3d88f0c1224b5fea_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_4c31844f2d6350fccb0612738f5dd7942047dd599544097e3d88f0c1224b5fea->leave($__internal_4c31844f2d6350fccb0612738f5dd7942047dd599544097e3d88f0c1224b5fea_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_7439038abc8e47db60612d9a075bb126ebb684a049f7f195028d4ed925a458e1 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_7439038abc8e47db60612d9a075bb126ebb684a049f7f195028d4ed925a458e1->enter($__internal_7439038abc8e47db60612d9a075bb126ebb684a049f7f195028d4ed925a458e1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <link href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpFoundationExtension')->generateAbsoluteUrl($this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("bundles/framework/css/exception.css")), "html", null, true);
        echo "\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
";
        
        $__internal_7439038abc8e47db60612d9a075bb126ebb684a049f7f195028d4ed925a458e1->leave($__internal_7439038abc8e47db60612d9a075bb126ebb684a049f7f195028d4ed925a458e1_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_27e31d7f794cd3814e651e67d0698f596f2a9caaeb3d7f272cce51e7d8d3002d = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_27e31d7f794cd3814e651e67d0698f596f2a9caaeb3d7f272cce51e7d8d3002d->enter($__internal_27e31d7f794cd3814e651e67d0698f596f2a9caaeb3d7f272cce51e7d8d3002d_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        // line 8
        echo "    ";
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["exception"]) ? $context["exception"] : $this->getContext($context, "exception")), "message", array()), "html", null, true);
        echo " (";
        echo twig_escape_filter($this->env, (isset($context["status_code"]) ? $context["status_code"] : $this->getContext($context, "status_code")), "html", null, true);
        echo " ";
        echo twig_escape_filter($this->env, (isset($context["status_text"]) ? $context["status_text"] : $this->getContext($context, "status_text")), "html", null, true);
        echo ")
";
        
        $__internal_27e31d7f794cd3814e651e67d0698f596f2a9caaeb3d7f272cce51e7d8d3002d->leave($__internal_27e31d7f794cd3814e651e67d0698f596f2a9caaeb3d7f272cce51e7d8d3002d_prof);

    }

    // line 11
    public function block_body($context, array $blocks = array())
    {
        $__internal_e2876c44d026c9203abc69288c6ad61aaa93d5f3a910833c644d87640dafc7b4 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e2876c44d026c9203abc69288c6ad61aaa93d5f3a910833c644d87640dafc7b4->enter($__internal_e2876c44d026c9203abc69288c6ad61aaa93d5f3a910833c644d87640dafc7b4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 12
        echo "    ";
        $this->loadTemplate("@Twig/Exception/exception.html.twig", "@Twig/Exception/exception_full.html.twig", 12)->display($context);
        
        $__internal_e2876c44d026c9203abc69288c6ad61aaa93d5f3a910833c644d87640dafc7b4->leave($__internal_e2876c44d026c9203abc69288c6ad61aaa93d5f3a910833c644d87640dafc7b4_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/Exception/exception_full.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  78 => 12,  72 => 11,  58 => 8,  52 => 7,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@Twig/layout.html.twig' %}

{% block head %}
    <link href=\"{{ absolute_url(asset('bundles/framework/css/exception.css')) }}\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
{% endblock %}

{% block title %}
    {{ exception.message }} ({{ status_code }} {{ status_text }})
{% endblock %}

{% block body %}
    {% include '@Twig/Exception/exception.html.twig' %}
{% endblock %}
";
    }
}

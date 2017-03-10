<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_787eda4d6bbfe789ef5dc2363020432dc677403037add2f3014ff555b558d9f5 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/router.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
            'menu' => array($this, 'block_menu'),
            'panel' => array($this, 'block_panel'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_29324bdea91095fa1d45e92f322f94f045d714fbb4ade07bd8e11f153e573fd4 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_29324bdea91095fa1d45e92f322f94f045d714fbb4ade07bd8e11f153e573fd4->enter($__internal_29324bdea91095fa1d45e92f322f94f045d714fbb4ade07bd8e11f153e573fd4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_29324bdea91095fa1d45e92f322f94f045d714fbb4ade07bd8e11f153e573fd4->leave($__internal_29324bdea91095fa1d45e92f322f94f045d714fbb4ade07bd8e11f153e573fd4_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_b315201a42e7123fbc8598ff6b490f8ff7bc11bacd708ba81aa24ef76e303b85 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b315201a42e7123fbc8598ff6b490f8ff7bc11bacd708ba81aa24ef76e303b85->enter($__internal_b315201a42e7123fbc8598ff6b490f8ff7bc11bacd708ba81aa24ef76e303b85_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_b315201a42e7123fbc8598ff6b490f8ff7bc11bacd708ba81aa24ef76e303b85->leave($__internal_b315201a42e7123fbc8598ff6b490f8ff7bc11bacd708ba81aa24ef76e303b85_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_91841f819492e7335dc2ae4128ddce789853df329d7d01cc308d3678d628273f = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_91841f819492e7335dc2ae4128ddce789853df329d7d01cc308d3678d628273f->enter($__internal_91841f819492e7335dc2ae4128ddce789853df329d7d01cc308d3678d628273f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_91841f819492e7335dc2ae4128ddce789853df329d7d01cc308d3678d628273f->leave($__internal_91841f819492e7335dc2ae4128ddce789853df329d7d01cc308d3678d628273f_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_c9a7248c6b087c657573a18d71ea519b0af9c56743226a51cc23d510b0b652bf = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c9a7248c6b087c657573a18d71ea519b0af9c56743226a51cc23d510b0b652bf->enter($__internal_c9a7248c6b087c657573a18d71ea519b0af9c56743226a51cc23d510b0b652bf_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_c9a7248c6b087c657573a18d71ea519b0af9c56743226a51cc23d510b0b652bf->leave($__internal_c9a7248c6b087c657573a18d71ea519b0af9c56743226a51cc23d510b0b652bf_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/router.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 13,  67 => 12,  56 => 7,  53 => 6,  47 => 5,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block toolbar %}{% endblock %}

{% block menu %}
<span class=\"label\">
    <span class=\"icon\">{{ include('@WebProfiler/Icon/router.svg') }}</span>
    <strong>Routing</strong>
</span>
{% endblock %}

{% block panel %}
    {{ render(path('_profiler_router', { token: token })) }}
{% endblock %}
";
    }
}

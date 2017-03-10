<?php

/* @WebProfiler/Collector/exception.html.twig */
class __TwigTemplate_70948d5924a1a751b5e015400f662f9914de4e95502dc774215477bf45ed47b6 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/exception.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
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
        $__internal_eb66b6cc0032034b51255e5f4e863b2a41bfe7d4c2f7d76f9d5f9226e8296b37 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_eb66b6cc0032034b51255e5f4e863b2a41bfe7d4c2f7d76f9d5f9226e8296b37->enter($__internal_eb66b6cc0032034b51255e5f4e863b2a41bfe7d4c2f7d76f9d5f9226e8296b37_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_eb66b6cc0032034b51255e5f4e863b2a41bfe7d4c2f7d76f9d5f9226e8296b37->leave($__internal_eb66b6cc0032034b51255e5f4e863b2a41bfe7d4c2f7d76f9d5f9226e8296b37_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_e99c7d6359d77266a0b19ce5070a86cbb478ed21617a614a9f8691e81ef210e0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_e99c7d6359d77266a0b19ce5070a86cbb478ed21617a614a9f8691e81ef210e0->enter($__internal_e99c7d6359d77266a0b19ce5070a86cbb478ed21617a614a9f8691e81ef210e0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    ";
        if ($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 5
            echo "        <style>
            ";
            // line 6
            echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception_css", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
            echo "
        </style>
    ";
        }
        // line 9
        echo "    ";
        $this->displayParentBlock("head", $context, $blocks);
        echo "
";
        
        $__internal_e99c7d6359d77266a0b19ce5070a86cbb478ed21617a614a9f8691e81ef210e0->leave($__internal_e99c7d6359d77266a0b19ce5070a86cbb478ed21617a614a9f8691e81ef210e0_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_43324bc854f2aafde80d499989b9e56f5d91617a4f510e1440e37f1fb7507985 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_43324bc854f2aafde80d499989b9e56f5d91617a4f510e1440e37f1fb7507985->enter($__internal_43324bc854f2aafde80d499989b9e56f5d91617a4f510e1440e37f1fb7507985_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 13
        echo "    <span class=\"label ";
        echo (($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) ? ("label-status-error") : ("disabled"));
        echo "\">
        <span class=\"icon\">";
        // line 14
        echo twig_include($this->env, $context, "@WebProfiler/Icon/exception.svg");
        echo "</span>
        <strong>Exception</strong>
        ";
        // line 16
        if ($this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 17
            echo "            <span class=\"count\">
                <span>1</span>
            </span>
        ";
        }
        // line 21
        echo "    </span>
";
        
        $__internal_43324bc854f2aafde80d499989b9e56f5d91617a4f510e1440e37f1fb7507985->leave($__internal_43324bc854f2aafde80d499989b9e56f5d91617a4f510e1440e37f1fb7507985_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_3a0f4152c0be787ea5d3e7a56c5875d19bb2ad528e8f9c9c9379b9db445b1a31 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_3a0f4152c0be787ea5d3e7a56c5875d19bb2ad528e8f9c9c9379b9db445b1a31->enter($__internal_3a0f4152c0be787ea5d3e7a56c5875d19bb2ad528e8f9c9c9379b9db445b1a31_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 25
        echo "    <h2>Exceptions</h2>

    ";
        // line 27
        if ( !$this->getAttribute((isset($context["collector"]) ? $context["collector"] : $this->getContext($context, "collector")), "hasexception", array())) {
            // line 28
            echo "        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    ";
        } else {
            // line 32
            echo "        <div class=\"sf-reset\">
            ";
            // line 33
            echo $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpKernelExtension')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception", array("token" => (isset($context["token"]) ? $context["token"] : $this->getContext($context, "token")))));
            echo "
        </div>
    ";
        }
        
        $__internal_3a0f4152c0be787ea5d3e7a56c5875d19bb2ad528e8f9c9c9379b9db445b1a31->leave($__internal_3a0f4152c0be787ea5d3e7a56c5875d19bb2ad528e8f9c9c9379b9db445b1a31_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/exception.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  117 => 33,  114 => 32,  108 => 28,  106 => 27,  102 => 25,  96 => 24,  88 => 21,  82 => 17,  80 => 16,  75 => 14,  70 => 13,  64 => 12,  54 => 9,  48 => 6,  45 => 5,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@WebProfiler/Profiler/layout.html.twig' %}

{% block head %}
    {% if collector.hasexception %}
        <style>
            {{ render(path('_profiler_exception_css', { token: token })) }}
        </style>
    {% endif %}
    {{ parent() }}
{% endblock %}

{% block menu %}
    <span class=\"label {{ collector.hasexception ? 'label-status-error' : 'disabled' }}\">
        <span class=\"icon\">{{ include('@WebProfiler/Icon/exception.svg') }}</span>
        <strong>Exception</strong>
        {% if collector.hasexception %}
            <span class=\"count\">
                <span>1</span>
            </span>
        {% endif %}
    </span>
{% endblock %}

{% block panel %}
    <h2>Exceptions</h2>

    {% if not collector.hasexception %}
        <div class=\"empty\">
            <p>No exception was thrown and caught during the request.</p>
        </div>
    {% else %}
        <div class=\"sf-reset\">
            {{ render(path('_profiler_exception', { token: token })) }}
        </div>
    {% endif %}
{% endblock %}
";
    }
}

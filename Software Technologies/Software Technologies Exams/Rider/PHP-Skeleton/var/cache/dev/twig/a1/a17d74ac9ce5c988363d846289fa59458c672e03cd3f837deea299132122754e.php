<?php

/* @WebProfiler/Collector/exception.html.twig */
class __TwigTemplate_0acfe6e0d74ca654a1a4affc281db3f3a85b89e0dc74c98b09bfaf6fb7b9bf4c extends Twig_Template
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
        $__internal_6f4d02c31463d3a61d1639617645d088ca0fbf4f6ba00ec1046be13c59e73e6b = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_6f4d02c31463d3a61d1639617645d088ca0fbf4f6ba00ec1046be13c59e73e6b->enter($__internal_6f4d02c31463d3a61d1639617645d088ca0fbf4f6ba00ec1046be13c59e73e6b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $__internal_217bf19b5924258fd94256c52ab028251b4d060e05d5f5047eee5023b945bff0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_217bf19b5924258fd94256c52ab028251b4d060e05d5f5047eee5023b945bff0->enter($__internal_217bf19b5924258fd94256c52ab028251b4d060e05d5f5047eee5023b945bff0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/exception.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_6f4d02c31463d3a61d1639617645d088ca0fbf4f6ba00ec1046be13c59e73e6b->leave($__internal_6f4d02c31463d3a61d1639617645d088ca0fbf4f6ba00ec1046be13c59e73e6b_prof);

        
        $__internal_217bf19b5924258fd94256c52ab028251b4d060e05d5f5047eee5023b945bff0->leave($__internal_217bf19b5924258fd94256c52ab028251b4d060e05d5f5047eee5023b945bff0_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_0ffc057a50002df6a937fb115599a913ce2863e9d2c97642db8e37bd4f4d2c9e = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_0ffc057a50002df6a937fb115599a913ce2863e9d2c97642db8e37bd4f4d2c9e->enter($__internal_0ffc057a50002df6a937fb115599a913ce2863e9d2c97642db8e37bd4f4d2c9e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_6d05e3d4691c849c9d88d259ef564f7c1a9fba100ff719dc7922004d575fcfee = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_6d05e3d4691c849c9d88d259ef564f7c1a9fba100ff719dc7922004d575fcfee->enter($__internal_6d05e3d4691c849c9d88d259ef564f7c1a9fba100ff719dc7922004d575fcfee_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    ";
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 5
            echo "        <style>
            ";
            // line 6
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception_css", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </style>
    ";
        }
        // line 9
        echo "    ";
        $this->displayParentBlock("head", $context, $blocks);
        echo "
";
        
        $__internal_6d05e3d4691c849c9d88d259ef564f7c1a9fba100ff719dc7922004d575fcfee->leave($__internal_6d05e3d4691c849c9d88d259ef564f7c1a9fba100ff719dc7922004d575fcfee_prof);

        
        $__internal_0ffc057a50002df6a937fb115599a913ce2863e9d2c97642db8e37bd4f4d2c9e->leave($__internal_0ffc057a50002df6a937fb115599a913ce2863e9d2c97642db8e37bd4f4d2c9e_prof);

    }

    // line 12
    public function block_menu($context, array $blocks = array())
    {
        $__internal_9cc609de3cb12ee3241453599b8033c00900eb3d208caeffe8ef93a044ad5524 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_9cc609de3cb12ee3241453599b8033c00900eb3d208caeffe8ef93a044ad5524->enter($__internal_9cc609de3cb12ee3241453599b8033c00900eb3d208caeffe8ef93a044ad5524_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_63c29eb02c81ca5fdcfa5df027da60fe236151ce24ef54096ed052ebb90365a0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_63c29eb02c81ca5fdcfa5df027da60fe236151ce24ef54096ed052ebb90365a0->enter($__internal_63c29eb02c81ca5fdcfa5df027da60fe236151ce24ef54096ed052ebb90365a0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 13
        echo "    <span class=\"label ";
        echo (($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) ? ("label-status-error") : ("disabled"));
        echo "\">
        <span class=\"icon\">";
        // line 14
        echo twig_include($this->env, $context, "@WebProfiler/Icon/exception.svg");
        echo "</span>
        <strong>Exception</strong>
        ";
        // line 16
        if ($this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
            // line 17
            echo "            <span class=\"count\">
                <span>1</span>
            </span>
        ";
        }
        // line 21
        echo "    </span>
";
        
        $__internal_63c29eb02c81ca5fdcfa5df027da60fe236151ce24ef54096ed052ebb90365a0->leave($__internal_63c29eb02c81ca5fdcfa5df027da60fe236151ce24ef54096ed052ebb90365a0_prof);

        
        $__internal_9cc609de3cb12ee3241453599b8033c00900eb3d208caeffe8ef93a044ad5524->leave($__internal_9cc609de3cb12ee3241453599b8033c00900eb3d208caeffe8ef93a044ad5524_prof);

    }

    // line 24
    public function block_panel($context, array $blocks = array())
    {
        $__internal_f34fc712a8724c97952ef8afd8dbf07665d1d05961b74b81f6b5c59d5288cc2e = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_f34fc712a8724c97952ef8afd8dbf07665d1d05961b74b81f6b5c59d5288cc2e->enter($__internal_f34fc712a8724c97952ef8afd8dbf07665d1d05961b74b81f6b5c59d5288cc2e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_cddc9c72f55c9f4f080f21cbe41830756af8d594c0df361203f1537b972f5218 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_cddc9c72f55c9f4f080f21cbe41830756af8d594c0df361203f1537b972f5218->enter($__internal_cddc9c72f55c9f4f080f21cbe41830756af8d594c0df361203f1537b972f5218_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 25
        echo "    <h2>Exceptions</h2>

    ";
        // line 27
        if ( !$this->getAttribute(($context["collector"] ?? $this->getContext($context, "collector")), "hasexception", array())) {
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
            echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_exception", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
            echo "
        </div>
    ";
        }
        
        $__internal_cddc9c72f55c9f4f080f21cbe41830756af8d594c0df361203f1537b972f5218->leave($__internal_cddc9c72f55c9f4f080f21cbe41830756af8d594c0df361203f1537b972f5218_prof);

        
        $__internal_f34fc712a8724c97952ef8afd8dbf07665d1d05961b74b81f6b5c59d5288cc2e->leave($__internal_f34fc712a8724c97952ef8afd8dbf07665d1d05961b74b81f6b5c59d5288cc2e_prof);

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
        return array (  138 => 33,  135 => 32,  129 => 28,  127 => 27,  123 => 25,  114 => 24,  103 => 21,  97 => 17,  95 => 16,  90 => 14,  85 => 13,  76 => 12,  63 => 9,  57 => 6,  54 => 5,  51 => 4,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@WebProfiler/Profiler/layout.html.twig' %}

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
", "@WebProfiler/Collector/exception.html.twig", "C:\\Users\\User\\Desktop\\Rider\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\exception.html.twig");
    }
}

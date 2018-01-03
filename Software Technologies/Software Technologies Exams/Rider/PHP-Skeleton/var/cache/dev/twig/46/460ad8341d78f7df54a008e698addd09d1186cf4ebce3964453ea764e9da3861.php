<?php

/* @WebProfiler/Collector/ajax.html.twig */
class __TwigTemplate_1ba2844ce327644c79ce021cb22291f7c7f4345900a886756bff7f8093a09dc7 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@WebProfiler/Profiler/layout.html.twig", "@WebProfiler/Collector/ajax.html.twig", 1);
        $this->blocks = array(
            'toolbar' => array($this, 'block_toolbar'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@WebProfiler/Profiler/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_b450da7177a5fc6981bb2ee0a5c577dbf6c38c67bd64daf1d61be4237bd4c353 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_b450da7177a5fc6981bb2ee0a5c577dbf6c38c67bd64daf1d61be4237bd4c353->enter($__internal_b450da7177a5fc6981bb2ee0a5c577dbf6c38c67bd64daf1d61be4237bd4c353_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/ajax.html.twig"));

        $__internal_ef1d0cc13ae05a793779b9e7bb0ecadf40439aa7ac0469e28019e4001deab6f0 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ef1d0cc13ae05a793779b9e7bb0ecadf40439aa7ac0469e28019e4001deab6f0->enter($__internal_ef1d0cc13ae05a793779b9e7bb0ecadf40439aa7ac0469e28019e4001deab6f0_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/ajax.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_b450da7177a5fc6981bb2ee0a5c577dbf6c38c67bd64daf1d61be4237bd4c353->leave($__internal_b450da7177a5fc6981bb2ee0a5c577dbf6c38c67bd64daf1d61be4237bd4c353_prof);

        
        $__internal_ef1d0cc13ae05a793779b9e7bb0ecadf40439aa7ac0469e28019e4001deab6f0->leave($__internal_ef1d0cc13ae05a793779b9e7bb0ecadf40439aa7ac0469e28019e4001deab6f0_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_f648d0c7de9e1dc38463fe5f8f3cdbf27b01aa15178fc1e97723baafbfeca458 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_f648d0c7de9e1dc38463fe5f8f3cdbf27b01aa15178fc1e97723baafbfeca458->enter($__internal_f648d0c7de9e1dc38463fe5f8f3cdbf27b01aa15178fc1e97723baafbfeca458_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_a189941fbca4cd76e473bbde7baf8e87fe7395d6be0aec2837c020682c881bb8 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_a189941fbca4cd76e473bbde7baf8e87fe7395d6be0aec2837c020682c881bb8->enter($__internal_a189941fbca4cd76e473bbde7baf8e87fe7395d6be0aec2837c020682c881bb8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        // line 4
        echo "    ";
        ob_start();
        // line 5
        echo "        ";
        echo twig_include($this->env, $context, "@WebProfiler/Icon/ajax.svg");
        echo "
        <span class=\"sf-toolbar-value sf-toolbar-ajax-request-counter\">0</span>
    ";
        $context["icon"] = ('' === $tmp = ob_get_clean()) ? '' : new Twig_Markup($tmp, $this->env->getCharset());
        // line 8
        echo "
    ";
        // line 9
        $context["text"] = ('' === $tmp = "        <div class=\"sf-toolbar-info-piece\">
            <b class=\"sf-toolbar-ajax-info\"></b>
        </div>
        <div class=\"sf-toolbar-info-piece\">
            <table class=\"sf-toolbar-ajax-requests\">
                <thead>
                    <tr>
                        <th>Method</th>
                        <th>Type</th>
                        <th>Status</th>
                        <th>URL</th>
                        <th>Time</th>
                        <th>Profile</th>
                    </tr>
                </thead>
                <tbody class=\"sf-toolbar-ajax-request-list\"></tbody>
            </table>
        </div>
    ") ? '' : new Twig_Markup($tmp, $this->env->getCharset());
        // line 29
        echo "
    ";
        // line 30
        echo twig_include($this->env, $context, "@WebProfiler/Profiler/toolbar_item.html.twig", array("link" => false));
        echo "
";
        
        $__internal_a189941fbca4cd76e473bbde7baf8e87fe7395d6be0aec2837c020682c881bb8->leave($__internal_a189941fbca4cd76e473bbde7baf8e87fe7395d6be0aec2837c020682c881bb8_prof);

        
        $__internal_f648d0c7de9e1dc38463fe5f8f3cdbf27b01aa15178fc1e97723baafbfeca458->leave($__internal_f648d0c7de9e1dc38463fe5f8f3cdbf27b01aa15178fc1e97723baafbfeca458_prof);

    }

    public function getTemplateName()
    {
        return "@WebProfiler/Collector/ajax.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  85 => 30,  82 => 29,  62 => 9,  59 => 8,  52 => 5,  49 => 4,  40 => 3,  11 => 1,);
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

{% block toolbar %}
    {% set icon %}
        {{ include('@WebProfiler/Icon/ajax.svg') }}
        <span class=\"sf-toolbar-value sf-toolbar-ajax-request-counter\">0</span>
    {% endset %}

    {% set text %}
        <div class=\"sf-toolbar-info-piece\">
            <b class=\"sf-toolbar-ajax-info\"></b>
        </div>
        <div class=\"sf-toolbar-info-piece\">
            <table class=\"sf-toolbar-ajax-requests\">
                <thead>
                    <tr>
                        <th>Method</th>
                        <th>Type</th>
                        <th>Status</th>
                        <th>URL</th>
                        <th>Time</th>
                        <th>Profile</th>
                    </tr>
                </thead>
                <tbody class=\"sf-toolbar-ajax-request-list\"></tbody>
            </table>
        </div>
    {% endset %}

    {{ include('@WebProfiler/Profiler/toolbar_item.html.twig', { link: false }) }}
{% endblock %}
", "@WebProfiler/Collector/ajax.html.twig", "C:\\Users\\User\\Desktop\\Rider\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\ajax.html.twig");
    }
}

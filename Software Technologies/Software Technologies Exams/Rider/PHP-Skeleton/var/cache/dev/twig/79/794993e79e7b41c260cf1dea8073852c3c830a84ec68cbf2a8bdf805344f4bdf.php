<?php

/* @Twig/Exception/exception_full.html.twig */
class __TwigTemplate_237ff2a1e63d63cd1d0c80b7dcb8957f3d313ef90d0e7788debff48edc841ff3 extends Twig_Template
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
        $__internal_e6b724eb4ffe52def26aec809cec1b6a776856a5f362fe339a484eb4fad5c3f2 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_e6b724eb4ffe52def26aec809cec1b6a776856a5f362fe339a484eb4fad5c3f2->enter($__internal_e6b724eb4ffe52def26aec809cec1b6a776856a5f362fe339a484eb4fad5c3f2_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $__internal_46aa50a397eef3e6344653091d2ddeea14fb8fc02514fb4a638ab2dafa236652 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_46aa50a397eef3e6344653091d2ddeea14fb8fc02514fb4a638ab2dafa236652->enter($__internal_46aa50a397eef3e6344653091d2ddeea14fb8fc02514fb4a638ab2dafa236652_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_e6b724eb4ffe52def26aec809cec1b6a776856a5f362fe339a484eb4fad5c3f2->leave($__internal_e6b724eb4ffe52def26aec809cec1b6a776856a5f362fe339a484eb4fad5c3f2_prof);

        
        $__internal_46aa50a397eef3e6344653091d2ddeea14fb8fc02514fb4a638ab2dafa236652->leave($__internal_46aa50a397eef3e6344653091d2ddeea14fb8fc02514fb4a638ab2dafa236652_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_5fd02718b1bb919ac33cac16c8df06fd6487958580ca09439a549fb767f5b7f1 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_5fd02718b1bb919ac33cac16c8df06fd6487958580ca09439a549fb767f5b7f1->enter($__internal_5fd02718b1bb919ac33cac16c8df06fd6487958580ca09439a549fb767f5b7f1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_04113b8a0f7abc09736fc3070f12a7c70c54b9d622c8407d0813f95b4219fe2a = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_04113b8a0f7abc09736fc3070f12a7c70c54b9d622c8407d0813f95b4219fe2a->enter($__internal_04113b8a0f7abc09736fc3070f12a7c70c54b9d622c8407d0813f95b4219fe2a_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <style>
        .sf-reset .traces {
            padding-bottom: 14px;
        }
        .sf-reset .traces li {
            font-size: 12px;
            color: #868686;
            padding: 5px 4px;
            list-style-type: decimal;
            margin-left: 20px;
        }
        .sf-reset #logs .traces li.error {
            font-style: normal;
            color: #AA3333;
            background: #f9ecec;
        }
        .sf-reset #logs .traces li.warning {
            font-style: normal;
            background: #ffcc00;
        }
        /* fix for Opera not liking empty <li> */
        .sf-reset .traces li:after {
            content: \"\\00A0\";
        }
        .sf-reset .trace {
            border: 1px solid #D3D3D3;
            padding: 10px;
            overflow: auto;
            margin: 10px 0 20px;
        }
        .sf-reset .block-exception {
            -moz-border-radius: 16px;
            -webkit-border-radius: 16px;
            border-radius: 16px;
            margin-bottom: 20px;
            background-color: #f6f6f6;
            border: 1px solid #dfdfdf;
            padding: 30px 28px;
            word-wrap: break-word;
            overflow: hidden;
        }
        .sf-reset .block-exception div {
            color: #313131;
            font-size: 10px;
        }
        .sf-reset .block-exception-detected .illustration-exception,
        .sf-reset .block-exception-detected .text-exception {
            float: left;
        }
        .sf-reset .block-exception-detected .illustration-exception {
            width: 152px;
        }
        .sf-reset .block-exception-detected .text-exception {
            width: 670px;
            padding: 30px 44px 24px 46px;
            position: relative;
        }
        .sf-reset .text-exception .open-quote,
        .sf-reset .text-exception .close-quote {
            font-family: Arial, Helvetica, sans-serif;
            position: absolute;
            color: #C9C9C9;
            font-size: 8em;
        }
        .sf-reset .open-quote {
            top: 0;
            left: 0;
        }
        .sf-reset .close-quote {
            bottom: -0.5em;
            right: 50px;
        }
        .sf-reset .block-exception p {
            font-family: Arial, Helvetica, sans-serif;
        }
        .sf-reset .block-exception p a,
        .sf-reset .block-exception p a:hover {
            color: #565656;
        }
        .sf-reset .logs h2 {
            float: left;
            width: 654px;
        }
        .sf-reset .error-count, .sf-reset .support {
            float: right;
            width: 170px;
            text-align: right;
        }
        .sf-reset .error-count span {
             display: inline-block;
             background-color: #aacd4e;
             -moz-border-radius: 6px;
             -webkit-border-radius: 6px;
             border-radius: 6px;
             padding: 4px;
             color: white;
             margin-right: 2px;
             font-size: 11px;
             font-weight: bold;
        }

        .sf-reset .support a {
            display: inline-block;
            -moz-border-radius: 6px;
            -webkit-border-radius: 6px;
            border-radius: 6px;
            padding: 4px;
            color: #000000;
            margin-right: 2px;
            font-size: 11px;
            font-weight: bold;
        }

        .sf-reset .toggle {
            vertical-align: middle;
        }
        .sf-reset .linked ul,
        .sf-reset .linked li {
            display: inline;
        }
        .sf-reset #output-content {
            color: #000;
            font-size: 12px;
        }
        .sf-reset #traces-text pre {
            white-space: pre;
            font-size: 12px;
            font-family: monospace;
        }
    </style>
";
        
        $__internal_04113b8a0f7abc09736fc3070f12a7c70c54b9d622c8407d0813f95b4219fe2a->leave($__internal_04113b8a0f7abc09736fc3070f12a7c70c54b9d622c8407d0813f95b4219fe2a_prof);

        
        $__internal_5fd02718b1bb919ac33cac16c8df06fd6487958580ca09439a549fb767f5b7f1->leave($__internal_5fd02718b1bb919ac33cac16c8df06fd6487958580ca09439a549fb767f5b7f1_prof);

    }

    // line 136
    public function block_title($context, array $blocks = array())
    {
        $__internal_30ef7653aab5b4da60aec04bdba35f1ff99d0e096925e78068adc8ba556b2323 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_30ef7653aab5b4da60aec04bdba35f1ff99d0e096925e78068adc8ba556b2323->enter($__internal_30ef7653aab5b4da60aec04bdba35f1ff99d0e096925e78068adc8ba556b2323_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_c76ba4dc0ade8f42f507adfd901b393ab067c056c7e286149ee6790a717fe3b4 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c76ba4dc0ade8f42f507adfd901b393ab067c056c7e286149ee6790a717fe3b4->enter($__internal_c76ba4dc0ade8f42f507adfd901b393ab067c056c7e286149ee6790a717fe3b4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        // line 137
        echo "    ";
        echo twig_escape_filter($this->env, $this->getAttribute(($context["exception"] ?? $this->getContext($context, "exception")), "message", array()), "html", null, true);
        echo " (";
        echo twig_escape_filter($this->env, ($context["status_code"] ?? $this->getContext($context, "status_code")), "html", null, true);
        echo " ";
        echo twig_escape_filter($this->env, ($context["status_text"] ?? $this->getContext($context, "status_text")), "html", null, true);
        echo ")
";
        
        $__internal_c76ba4dc0ade8f42f507adfd901b393ab067c056c7e286149ee6790a717fe3b4->leave($__internal_c76ba4dc0ade8f42f507adfd901b393ab067c056c7e286149ee6790a717fe3b4_prof);

        
        $__internal_30ef7653aab5b4da60aec04bdba35f1ff99d0e096925e78068adc8ba556b2323->leave($__internal_30ef7653aab5b4da60aec04bdba35f1ff99d0e096925e78068adc8ba556b2323_prof);

    }

    // line 140
    public function block_body($context, array $blocks = array())
    {
        $__internal_0d28ffd1ef8b1d46728db2de6d2af0642fd47ed60b2d12aa4ce308bb50d08a03 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_0d28ffd1ef8b1d46728db2de6d2af0642fd47ed60b2d12aa4ce308bb50d08a03->enter($__internal_0d28ffd1ef8b1d46728db2de6d2af0642fd47ed60b2d12aa4ce308bb50d08a03_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_5b07cfac0fc687e52f2f4115fcf6d1aa65d7445124f6814ae1a4454a640b8dc8 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_5b07cfac0fc687e52f2f4115fcf6d1aa65d7445124f6814ae1a4454a640b8dc8->enter($__internal_5b07cfac0fc687e52f2f4115fcf6d1aa65d7445124f6814ae1a4454a640b8dc8_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 141
        echo "    ";
        $this->loadTemplate("@Twig/Exception/exception.html.twig", "@Twig/Exception/exception_full.html.twig", 141)->display($context);
        
        $__internal_5b07cfac0fc687e52f2f4115fcf6d1aa65d7445124f6814ae1a4454a640b8dc8->leave($__internal_5b07cfac0fc687e52f2f4115fcf6d1aa65d7445124f6814ae1a4454a640b8dc8_prof);

        
        $__internal_0d28ffd1ef8b1d46728db2de6d2af0642fd47ed60b2d12aa4ce308bb50d08a03->leave($__internal_0d28ffd1ef8b1d46728db2de6d2af0642fd47ed60b2d12aa4ce308bb50d08a03_prof);

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
        return array (  226 => 141,  217 => 140,  200 => 137,  191 => 136,  51 => 4,  42 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends '@Twig/layout.html.twig' %}

{% block head %}
    <style>
        .sf-reset .traces {
            padding-bottom: 14px;
        }
        .sf-reset .traces li {
            font-size: 12px;
            color: #868686;
            padding: 5px 4px;
            list-style-type: decimal;
            margin-left: 20px;
        }
        .sf-reset #logs .traces li.error {
            font-style: normal;
            color: #AA3333;
            background: #f9ecec;
        }
        .sf-reset #logs .traces li.warning {
            font-style: normal;
            background: #ffcc00;
        }
        /* fix for Opera not liking empty <li> */
        .sf-reset .traces li:after {
            content: \"\\00A0\";
        }
        .sf-reset .trace {
            border: 1px solid #D3D3D3;
            padding: 10px;
            overflow: auto;
            margin: 10px 0 20px;
        }
        .sf-reset .block-exception {
            -moz-border-radius: 16px;
            -webkit-border-radius: 16px;
            border-radius: 16px;
            margin-bottom: 20px;
            background-color: #f6f6f6;
            border: 1px solid #dfdfdf;
            padding: 30px 28px;
            word-wrap: break-word;
            overflow: hidden;
        }
        .sf-reset .block-exception div {
            color: #313131;
            font-size: 10px;
        }
        .sf-reset .block-exception-detected .illustration-exception,
        .sf-reset .block-exception-detected .text-exception {
            float: left;
        }
        .sf-reset .block-exception-detected .illustration-exception {
            width: 152px;
        }
        .sf-reset .block-exception-detected .text-exception {
            width: 670px;
            padding: 30px 44px 24px 46px;
            position: relative;
        }
        .sf-reset .text-exception .open-quote,
        .sf-reset .text-exception .close-quote {
            font-family: Arial, Helvetica, sans-serif;
            position: absolute;
            color: #C9C9C9;
            font-size: 8em;
        }
        .sf-reset .open-quote {
            top: 0;
            left: 0;
        }
        .sf-reset .close-quote {
            bottom: -0.5em;
            right: 50px;
        }
        .sf-reset .block-exception p {
            font-family: Arial, Helvetica, sans-serif;
        }
        .sf-reset .block-exception p a,
        .sf-reset .block-exception p a:hover {
            color: #565656;
        }
        .sf-reset .logs h2 {
            float: left;
            width: 654px;
        }
        .sf-reset .error-count, .sf-reset .support {
            float: right;
            width: 170px;
            text-align: right;
        }
        .sf-reset .error-count span {
             display: inline-block;
             background-color: #aacd4e;
             -moz-border-radius: 6px;
             -webkit-border-radius: 6px;
             border-radius: 6px;
             padding: 4px;
             color: white;
             margin-right: 2px;
             font-size: 11px;
             font-weight: bold;
        }

        .sf-reset .support a {
            display: inline-block;
            -moz-border-radius: 6px;
            -webkit-border-radius: 6px;
            border-radius: 6px;
            padding: 4px;
            color: #000000;
            margin-right: 2px;
            font-size: 11px;
            font-weight: bold;
        }

        .sf-reset .toggle {
            vertical-align: middle;
        }
        .sf-reset .linked ul,
        .sf-reset .linked li {
            display: inline;
        }
        .sf-reset #output-content {
            color: #000;
            font-size: 12px;
        }
        .sf-reset #traces-text pre {
            white-space: pre;
            font-size: 12px;
            font-family: monospace;
        }
    </style>
{% endblock %}

{% block title %}
    {{ exception.message }} ({{ status_code }} {{ status_text }})
{% endblock %}

{% block body %}
    {% include '@Twig/Exception/exception.html.twig' %}
{% endblock %}
", "@Twig/Exception/exception_full.html.twig", "C:\\Users\\User\\Desktop\\Rider\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\TwigBundle\\Resources\\views\\Exception\\exception_full.html.twig");
    }
}

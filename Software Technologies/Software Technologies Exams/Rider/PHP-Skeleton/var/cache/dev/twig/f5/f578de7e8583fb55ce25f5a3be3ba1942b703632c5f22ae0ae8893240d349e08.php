<?php

/* @WebProfiler/Collector/router.html.twig */
class __TwigTemplate_9cc36d5ec5add1c3b58a73800826077a427f692a9c4bcd893e7730774ba78d70 extends Twig_Template
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
        $__internal_75331465057d0d7fe20329d0586d2e75e5c0b6501d33470cbbaf99cc79949f26 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_75331465057d0d7fe20329d0586d2e75e5c0b6501d33470cbbaf99cc79949f26->enter($__internal_75331465057d0d7fe20329d0586d2e75e5c0b6501d33470cbbaf99cc79949f26_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $__internal_ead025cade5a2ac958200125f3048bb2383d595e25107baf2630141d9dd14d7e = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ead025cade5a2ac958200125f3048bb2383d595e25107baf2630141d9dd14d7e->enter($__internal_ead025cade5a2ac958200125f3048bb2383d595e25107baf2630141d9dd14d7e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@WebProfiler/Collector/router.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_75331465057d0d7fe20329d0586d2e75e5c0b6501d33470cbbaf99cc79949f26->leave($__internal_75331465057d0d7fe20329d0586d2e75e5c0b6501d33470cbbaf99cc79949f26_prof);

        
        $__internal_ead025cade5a2ac958200125f3048bb2383d595e25107baf2630141d9dd14d7e->leave($__internal_ead025cade5a2ac958200125f3048bb2383d595e25107baf2630141d9dd14d7e_prof);

    }

    // line 3
    public function block_toolbar($context, array $blocks = array())
    {
        $__internal_04ef892cd91ba84e281979136b96cf9e4c3b080046c2e60269f29a532ea52bcd = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_04ef892cd91ba84e281979136b96cf9e4c3b080046c2e60269f29a532ea52bcd->enter($__internal_04ef892cd91ba84e281979136b96cf9e4c3b080046c2e60269f29a532ea52bcd_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        $__internal_982593c212259b1f84f543b4a8132a1bf2e6838ba1f48209e4fddccafefab4b1 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_982593c212259b1f84f543b4a8132a1bf2e6838ba1f48209e4fddccafefab4b1->enter($__internal_982593c212259b1f84f543b4a8132a1bf2e6838ba1f48209e4fddccafefab4b1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "toolbar"));

        
        $__internal_982593c212259b1f84f543b4a8132a1bf2e6838ba1f48209e4fddccafefab4b1->leave($__internal_982593c212259b1f84f543b4a8132a1bf2e6838ba1f48209e4fddccafefab4b1_prof);

        
        $__internal_04ef892cd91ba84e281979136b96cf9e4c3b080046c2e60269f29a532ea52bcd->leave($__internal_04ef892cd91ba84e281979136b96cf9e4c3b080046c2e60269f29a532ea52bcd_prof);

    }

    // line 5
    public function block_menu($context, array $blocks = array())
    {
        $__internal_6a998f21e4e3406d535ee6da9b0e8c3c0d461b0399043733af2a5ef049f6c226 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_6a998f21e4e3406d535ee6da9b0e8c3c0d461b0399043733af2a5ef049f6c226->enter($__internal_6a998f21e4e3406d535ee6da9b0e8c3c0d461b0399043733af2a5ef049f6c226_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        $__internal_152b47daa7c10a49fb672097e468248b7f5436761a76f369a99a6ccf0c579404 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_152b47daa7c10a49fb672097e468248b7f5436761a76f369a99a6ccf0c579404->enter($__internal_152b47daa7c10a49fb672097e468248b7f5436761a76f369a99a6ccf0c579404_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "menu"));

        // line 6
        echo "<span class=\"label\">
    <span class=\"icon\">";
        // line 7
        echo twig_include($this->env, $context, "@WebProfiler/Icon/router.svg");
        echo "</span>
    <strong>Routing</strong>
</span>
";
        
        $__internal_152b47daa7c10a49fb672097e468248b7f5436761a76f369a99a6ccf0c579404->leave($__internal_152b47daa7c10a49fb672097e468248b7f5436761a76f369a99a6ccf0c579404_prof);

        
        $__internal_6a998f21e4e3406d535ee6da9b0e8c3c0d461b0399043733af2a5ef049f6c226->leave($__internal_6a998f21e4e3406d535ee6da9b0e8c3c0d461b0399043733af2a5ef049f6c226_prof);

    }

    // line 12
    public function block_panel($context, array $blocks = array())
    {
        $__internal_abcfef80fa967d352b0e40246c70983a8d820f2991c3f16c7b231e4f29c27123 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_abcfef80fa967d352b0e40246c70983a8d820f2991c3f16c7b231e4f29c27123->enter($__internal_abcfef80fa967d352b0e40246c70983a8d820f2991c3f16c7b231e4f29c27123_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        $__internal_12ee1b618b756fdefe9126e1e15b82575941954b34ad94253d298d63e94b22f6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_12ee1b618b756fdefe9126e1e15b82575941954b34ad94253d298d63e94b22f6->enter($__internal_12ee1b618b756fdefe9126e1e15b82575941954b34ad94253d298d63e94b22f6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "panel"));

        // line 13
        echo "    ";
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Extension\HttpKernelRuntime')->renderFragment($this->env->getExtension('Symfony\Bridge\Twig\Extension\RoutingExtension')->getPath("_profiler_router", array("token" => ($context["token"] ?? $this->getContext($context, "token")))));
        echo "
";
        
        $__internal_12ee1b618b756fdefe9126e1e15b82575941954b34ad94253d298d63e94b22f6->leave($__internal_12ee1b618b756fdefe9126e1e15b82575941954b34ad94253d298d63e94b22f6_prof);

        
        $__internal_abcfef80fa967d352b0e40246c70983a8d820f2991c3f16c7b231e4f29c27123->leave($__internal_abcfef80fa967d352b0e40246c70983a8d820f2991c3f16c7b231e4f29c27123_prof);

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
        return array (  94 => 13,  85 => 12,  71 => 7,  68 => 6,  59 => 5,  42 => 3,  11 => 1,);
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
", "@WebProfiler/Collector/router.html.twig", "C:\\Users\\User\\Desktop\\Rider\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\WebProfilerBundle\\Resources\\views\\Collector\\router.html.twig");
    }
}

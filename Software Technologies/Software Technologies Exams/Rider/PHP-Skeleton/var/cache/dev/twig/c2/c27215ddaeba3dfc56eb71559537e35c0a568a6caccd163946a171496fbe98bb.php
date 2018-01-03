<?php

/* :project:delete.html.twig */
class __TwigTemplate_95ed6f90a2f87a4dd4fd8a8a654ba46835b00a51611e215160345bb927c11637 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", ":project:delete.html.twig", 1);
        $this->blocks = array(
            'main' => array($this, 'block_main'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "base.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_7ee1877d5dfcb1fa016748153210a78721d5e1b73f4064f75b61e4a55fe3491b = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_7ee1877d5dfcb1fa016748153210a78721d5e1b73f4064f75b61e4a55fe3491b->enter($__internal_7ee1877d5dfcb1fa016748153210a78721d5e1b73f4064f75b61e4a55fe3491b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":project:delete.html.twig"));

        $__internal_d91a37da5ebba03959b8b52b710ed17ba87843c195cb8ab9cddc95836ae5f4cf = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d91a37da5ebba03959b8b52b710ed17ba87843c195cb8ab9cddc95836ae5f4cf->enter($__internal_d91a37da5ebba03959b8b52b710ed17ba87843c195cb8ab9cddc95836ae5f4cf_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":project:delete.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_7ee1877d5dfcb1fa016748153210a78721d5e1b73f4064f75b61e4a55fe3491b->leave($__internal_7ee1877d5dfcb1fa016748153210a78721d5e1b73f4064f75b61e4a55fe3491b_prof);

        
        $__internal_d91a37da5ebba03959b8b52b710ed17ba87843c195cb8ab9cddc95836ae5f4cf->leave($__internal_d91a37da5ebba03959b8b52b710ed17ba87843c195cb8ab9cddc95836ae5f4cf_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_cc1eba0f6514d0b4617264d783bb68c8a908b929c039d85cb6f6b2f73b37a07f = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_cc1eba0f6514d0b4617264d783bb68c8a908b929c039d85cb6f6b2f73b37a07f->enter($__internal_cc1eba0f6514d0b4617264d783bb68c8a908b929c039d85cb6f6b2f73b37a07f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_04a6e19d63c6a125ca7056e1a95633666a9558c317b36dd6b562b335aef11171 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_04a6e19d63c6a125ca7056e1a95633666a9558c317b36dd6b562b335aef11171->enter($__internal_04a6e19d63c6a125ca7056e1a95633666a9558c317b36dd6b562b335aef11171_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Delete Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" value=\"";
        // line 11
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "title", array()), "html", null, true);
        echo "\" disabled=\"disabled\"/>
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\"
                      disabled=\"disabled\">";
        // line 16
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "description", array()), "html", null, true);
        echo "</textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" value=\"";
        // line 20
        echo twig_escape_filter($this->env, $this->getAttribute(($context["project"] ?? $this->getContext($context, "project")), "budget", array()), "html", null, true);
        echo "\"
                   disabled=\"disabled\"/>
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Delete Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        ";
        // line 28
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "
    </form>
</div>
";
        
        $__internal_04a6e19d63c6a125ca7056e1a95633666a9558c317b36dd6b562b335aef11171->leave($__internal_04a6e19d63c6a125ca7056e1a95633666a9558c317b36dd6b562b335aef11171_prof);

        
        $__internal_cc1eba0f6514d0b4617264d783bb68c8a908b929c039d85cb6f6b2f73b37a07f->leave($__internal_cc1eba0f6514d0b4617264d783bb68c8a908b929c039d85cb6f6b2f73b37a07f_prof);

    }

    public function getTemplateName()
    {
        return ":project:delete.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  84 => 28,  73 => 20,  66 => 16,  58 => 11,  49 => 4,  40 => 3,  11 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{% extends \"base.html.twig\" %}

{% block main %}
<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Delete Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" value=\"{{ project.title }}\" disabled=\"disabled\"/>
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\"
                      disabled=\"disabled\">{{ project.description }}</textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" value=\"{{ project.budget }}\"
                   disabled=\"disabled\"/>
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Delete Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        {{ form_row(form._token) }}
    </form>
</div>
{% endblock %}", ":project:delete.html.twig", "C:\\Users\\User\\Desktop\\Rider\\PHP-Skeleton\\app/Resources\\views/project/delete.html.twig");
    }
}

<?php

/* :project:create.html.twig */
class __TwigTemplate_a26619a49ffd084be16fd01c1365c207ea143da1747cb7b24ebe98f98b4867ef extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("base.html.twig", ":project:create.html.twig", 1);
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
        $__internal_120ba373c9f93a19b2b7eec7fd0d75fbc5e634d44d0b1094c862bce703c35453 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_120ba373c9f93a19b2b7eec7fd0d75fbc5e634d44d0b1094c862bce703c35453->enter($__internal_120ba373c9f93a19b2b7eec7fd0d75fbc5e634d44d0b1094c862bce703c35453_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":project:create.html.twig"));

        $__internal_b5624c9badf21cad97b5f419a86c1b17226b06eba0004e30a2ec7435ff16cca2 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_b5624c9badf21cad97b5f419a86c1b17226b06eba0004e30a2ec7435ff16cca2->enter($__internal_b5624c9badf21cad97b5f419a86c1b17226b06eba0004e30a2ec7435ff16cca2_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", ":project:create.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_120ba373c9f93a19b2b7eec7fd0d75fbc5e634d44d0b1094c862bce703c35453->leave($__internal_120ba373c9f93a19b2b7eec7fd0d75fbc5e634d44d0b1094c862bce703c35453_prof);

        
        $__internal_b5624c9badf21cad97b5f419a86c1b17226b06eba0004e30a2ec7435ff16cca2->leave($__internal_b5624c9badf21cad97b5f419a86c1b17226b06eba0004e30a2ec7435ff16cca2_prof);

    }

    // line 3
    public function block_main($context, array $blocks = array())
    {
        $__internal_2407b7861e15e667f20293fe1d9c315a35ef6ecdba05c51603d69f6cce35ea97 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_2407b7861e15e667f20293fe1d9c315a35ef6ecdba05c51603d69f6cce35ea97->enter($__internal_2407b7861e15e667f20293fe1d9c315a35ef6ecdba05c51603d69f6cce35ea97_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_829aab15746b673c92b2db0dabe93ef6bb86d91a1117327d50b4380f22b9407b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_829aab15746b673c92b2db0dabe93ef6bb86d91a1117327d50b4380f22b9407b->enter($__internal_829aab15746b673c92b2db0dabe93ef6bb86d91a1117327d50b4380f22b9407b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        // line 4
        echo "<div class=\"wrapper\">
    <form class=\"project-create\" method=\"post\">
        <div class=\"create-header\">
            Create Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\"></textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Create Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        ";
        // line 26
        echo $this->env->getRuntime('Symfony\Bridge\Twig\Form\TwigRenderer')->searchAndRenderBlock($this->getAttribute(($context["form"] ?? $this->getContext($context, "form")), "_token", array()), 'row');
        echo "
    </form>
</div>
";
        
        $__internal_829aab15746b673c92b2db0dabe93ef6bb86d91a1117327d50b4380f22b9407b->leave($__internal_829aab15746b673c92b2db0dabe93ef6bb86d91a1117327d50b4380f22b9407b_prof);

        
        $__internal_2407b7861e15e667f20293fe1d9c315a35ef6ecdba05c51603d69f6cce35ea97->leave($__internal_2407b7861e15e667f20293fe1d9c315a35ef6ecdba05c51603d69f6cce35ea97_prof);

    }

    public function getTemplateName()
    {
        return ":project:create.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  73 => 26,  49 => 4,  40 => 3,  11 => 1,);
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
            Create Project
        </div>
        <div class=\"create-title\">
            <div class=\"create-title-label\">Title</div>
            <input class=\"create-title-content\" name=\"project[title]\" />
        </div>
        <div class=\"create-description\">
            <div class=\"create-description-label\">Description</div>
            <textarea rows=\"3\" class=\"create-description-content\" name=\"project[description]\"></textarea>
        </div>
        <div class=\"create-budget\">
            <div class=\"create-budget-label\">Budget</div>
            <input type=\"number\" min=\"0\" class=\"create-budget-content\" name=\"project[budget]\" />
        </div>
        <div class=\"create-button-holder\">
            <button type=\"submit\" class=\"submit-button\">Create Project</button>
            <a type=\"button\" href=\"/\" class=\"back-button\">Back</a>
        </div>

        {{ form_row(form._token) }}
    </form>
</div>
{% endblock %}", ":project:create.html.twig", "C:\\Users\\User\\Desktop\\Rider\\PHP-Skeleton\\app/Resources\\views/project/create.html.twig");
    }
}

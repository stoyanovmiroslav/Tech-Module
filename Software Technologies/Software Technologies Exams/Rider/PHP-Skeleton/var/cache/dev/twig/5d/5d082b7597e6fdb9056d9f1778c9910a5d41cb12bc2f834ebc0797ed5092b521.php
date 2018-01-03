<?php

/* @Twig/layout.html.twig */
class __TwigTemplate_ac4577b33a1508f28febae67b77f8b093663a6c91b13d448e6865acd42e10dd8 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'head' => array($this, 'block_head'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_630c695d5c16a69b162373b3cfdd7379c9be6b663218e4de8af1e3d4d468fd8e = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_630c695d5c16a69b162373b3cfdd7379c9be6b663218e4de8af1e3d4d468fd8e->enter($__internal_630c695d5c16a69b162373b3cfdd7379c9be6b663218e4de8af1e3d4d468fd8e_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/layout.html.twig"));

        $__internal_1dc3517f4231be3e92c559a5467977588df5ffe56cfffcaed88291f7a2a6cbb1 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1dc3517f4231be3e92c559a5467977588df5ffe56cfffcaed88291f7a2a6cbb1->enter($__internal_1dc3517f4231be3e92c559a5467977588df5ffe56cfffcaed88291f7a2a6cbb1_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/layout.html.twig"));

        // line 1
        echo "<!DOCTYPE html>
<html>
    <head>
        <meta charset=\"";
        // line 4
        echo twig_escape_filter($this->env, $this->env->getCharset(), "html", null, true);
        echo "\" />
        <meta name=\"robots\" content=\"noindex,nofollow\" />
        <meta name=\"viewport\" content=\"width=device-width,initial-scale=1\" />
        <title>";
        // line 7
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
        <link rel=\"icon\" type=\"image/png\" href=\"";
        // line 8
        echo twig_include($this->env, $context, "@Twig/images/favicon.png.base64");
        echo "\">
        <style>";
        // line 9
        echo twig_include($this->env, $context, "@Twig/exception.css.twig");
        echo "</style>
        ";
        // line 10
        $this->displayBlock('head', $context, $blocks);
        // line 11
        echo "    </head>
    <body>
        <header>
            <div class=\"container\">
                <h1 class=\"logo\">";
        // line 15
        echo twig_include($this->env, $context, "@Twig/images/symfony-logo.svg");
        echo " Symfony Exception</h1>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/doc\">
                        <span class=\"icon\">";
        // line 19
        echo twig_include($this->env, $context, "@Twig/images/icon-book.svg");
        echo "</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Docs
                    </a>
                </div>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/support\">
                        <span class=\"icon\">";
        // line 26
        echo twig_include($this->env, $context, "@Twig/images/icon-support.svg");
        echo "</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Support
                    </a>
                </div>
            </div>
        </header>

        ";
        // line 33
        $this->displayBlock('body', $context, $blocks);
        // line 34
        echo "        ";
        echo twig_include($this->env, $context, "@Twig/base_js.html.twig");
        echo "
    </body>
</html>
";
        
        $__internal_630c695d5c16a69b162373b3cfdd7379c9be6b663218e4de8af1e3d4d468fd8e->leave($__internal_630c695d5c16a69b162373b3cfdd7379c9be6b663218e4de8af1e3d4d468fd8e_prof);

        
        $__internal_1dc3517f4231be3e92c559a5467977588df5ffe56cfffcaed88291f7a2a6cbb1->leave($__internal_1dc3517f4231be3e92c559a5467977588df5ffe56cfffcaed88291f7a2a6cbb1_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_ccf971ad2f41bfbfef4e27bb5e9860f28a9cd635367191037c88b06bea908217 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_ccf971ad2f41bfbfef4e27bb5e9860f28a9cd635367191037c88b06bea908217->enter($__internal_ccf971ad2f41bfbfef4e27bb5e9860f28a9cd635367191037c88b06bea908217_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_ead16fd0ef879cae353b20f5c23efeea234d15568d24314b04ee418062277d63 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ead16fd0ef879cae353b20f5c23efeea234d15568d24314b04ee418062277d63->enter($__internal_ead16fd0ef879cae353b20f5c23efeea234d15568d24314b04ee418062277d63_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        
        $__internal_ead16fd0ef879cae353b20f5c23efeea234d15568d24314b04ee418062277d63->leave($__internal_ead16fd0ef879cae353b20f5c23efeea234d15568d24314b04ee418062277d63_prof);

        
        $__internal_ccf971ad2f41bfbfef4e27bb5e9860f28a9cd635367191037c88b06bea908217->leave($__internal_ccf971ad2f41bfbfef4e27bb5e9860f28a9cd635367191037c88b06bea908217_prof);

    }

    // line 10
    public function block_head($context, array $blocks = array())
    {
        $__internal_429eac7b811e457c42a4bf05103bfc39d225eabd69f86350546fd1962cf52e55 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_429eac7b811e457c42a4bf05103bfc39d225eabd69f86350546fd1962cf52e55->enter($__internal_429eac7b811e457c42a4bf05103bfc39d225eabd69f86350546fd1962cf52e55_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        $__internal_354a9bbe8ab624cef38430ba19d2e2cdbf6cd6be594ff4e4091b696879d26dab = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_354a9bbe8ab624cef38430ba19d2e2cdbf6cd6be594ff4e4091b696879d26dab->enter($__internal_354a9bbe8ab624cef38430ba19d2e2cdbf6cd6be594ff4e4091b696879d26dab_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        
        $__internal_354a9bbe8ab624cef38430ba19d2e2cdbf6cd6be594ff4e4091b696879d26dab->leave($__internal_354a9bbe8ab624cef38430ba19d2e2cdbf6cd6be594ff4e4091b696879d26dab_prof);

        
        $__internal_429eac7b811e457c42a4bf05103bfc39d225eabd69f86350546fd1962cf52e55->leave($__internal_429eac7b811e457c42a4bf05103bfc39d225eabd69f86350546fd1962cf52e55_prof);

    }

    // line 33
    public function block_body($context, array $blocks = array())
    {
        $__internal_efc8f937947414fe1b72065d207d2a9485c8a3476851625042017ec8db73ad15 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_efc8f937947414fe1b72065d207d2a9485c8a3476851625042017ec8db73ad15->enter($__internal_efc8f937947414fe1b72065d207d2a9485c8a3476851625042017ec8db73ad15_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_1e4e3b346b47eacf224a24b9c418cc3f7ca472d30f345c8545aaf082677eab29 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1e4e3b346b47eacf224a24b9c418cc3f7ca472d30f345c8545aaf082677eab29->enter($__internal_1e4e3b346b47eacf224a24b9c418cc3f7ca472d30f345c8545aaf082677eab29_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        
        $__internal_1e4e3b346b47eacf224a24b9c418cc3f7ca472d30f345c8545aaf082677eab29->leave($__internal_1e4e3b346b47eacf224a24b9c418cc3f7ca472d30f345c8545aaf082677eab29_prof);

        
        $__internal_efc8f937947414fe1b72065d207d2a9485c8a3476851625042017ec8db73ad15->leave($__internal_efc8f937947414fe1b72065d207d2a9485c8a3476851625042017ec8db73ad15_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/layout.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  137 => 33,  120 => 10,  103 => 7,  88 => 34,  86 => 33,  76 => 26,  66 => 19,  59 => 15,  53 => 11,  51 => 10,  47 => 9,  43 => 8,  39 => 7,  33 => 4,  28 => 1,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("<!DOCTYPE html>
<html>
    <head>
        <meta charset=\"{{ _charset }}\" />
        <meta name=\"robots\" content=\"noindex,nofollow\" />
        <meta name=\"viewport\" content=\"width=device-width,initial-scale=1\" />
        <title>{% block title %}{% endblock %}</title>
        <link rel=\"icon\" type=\"image/png\" href=\"{{ include('@Twig/images/favicon.png.base64') }}\">
        <style>{{ include('@Twig/exception.css.twig') }}</style>
        {% block head %}{% endblock %}
    </head>
    <body>
        <header>
            <div class=\"container\">
                <h1 class=\"logo\">{{ include('@Twig/images/symfony-logo.svg') }} Symfony Exception</h1>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/doc\">
                        <span class=\"icon\">{{ include('@Twig/images/icon-book.svg') }}</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Docs
                    </a>
                </div>

                <div class=\"help-link\">
                    <a href=\"https://symfony.com/support\">
                        <span class=\"icon\">{{ include('@Twig/images/icon-support.svg') }}</span>
                        <span class=\"hidden-xs-down\">Symfony</span> Support
                    </a>
                </div>
            </div>
        </header>

        {% block body %}{% endblock %}
        {{ include('@Twig/base_js.html.twig') }}
    </body>
</html>
", "@Twig/layout.html.twig", "C:\\Users\\User\\Desktop\\Rider\\PHP-Skeleton\\vendor\\symfony\\symfony\\src\\Symfony\\Bundle\\TwigBundle\\Resources\\views\\layout.html.twig");
    }
}

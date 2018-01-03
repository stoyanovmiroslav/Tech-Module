<?php

/* base.html.twig */
class __TwigTemplate_a17f9d7aa975e34f4e0cc44eeab7f33089147d69ffdc6090114c99e26dfbd157 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'title' => array($this, 'block_title'),
            'stylesheets' => array($this, 'block_stylesheets'),
            'body_id' => array($this, 'block_body_id'),
            'body' => array($this, 'block_body'),
            'main' => array($this, 'block_main'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_3152e3b6c613d3867511dc6ea1c636b3cd9504b18213da4947b423c871477f03 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_3152e3b6c613d3867511dc6ea1c636b3cd9504b18213da4947b423c871477f03->enter($__internal_3152e3b6c613d3867511dc6ea1c636b3cd9504b18213da4947b423c871477f03_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        $__internal_bcb3299895b5af27023f19b7c1270174cafad815b0ad7de588c439db1b28ae51 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_bcb3299895b5af27023f19b7c1270174cafad815b0ad7de588c439db1b28ae51->enter($__internal_bcb3299895b5af27023f19b7c1270174cafad815b0ad7de588c439db1b28ae51_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "base.html.twig"));

        // line 6
        echo "<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <title>";
        // line 10
        $this->displayBlock('title', $context, $blocks);
        echo "</title>
    ";
        // line 11
        $this->displayBlock('stylesheets', $context, $blocks);
        // line 16
        echo "    <link rel=\"icon\" type=\"image/x-icon\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("favicon.ico"), "html", null, true);
        echo "\"/>
</head>

<body id=\"";
        // line 19
        $this->displayBlock('body_id', $context, $blocks);
        echo "\">
";
        // line 20
        $this->displayBlock('body', $context, $blocks);
        // line 23
        echo "</body>
</html>
";
        
        $__internal_3152e3b6c613d3867511dc6ea1c636b3cd9504b18213da4947b423c871477f03->leave($__internal_3152e3b6c613d3867511dc6ea1c636b3cd9504b18213da4947b423c871477f03_prof);

        
        $__internal_bcb3299895b5af27023f19b7c1270174cafad815b0ad7de588c439db1b28ae51->leave($__internal_bcb3299895b5af27023f19b7c1270174cafad815b0ad7de588c439db1b28ae51_prof);

    }

    // line 10
    public function block_title($context, array $blocks = array())
    {
        $__internal_bc9236367d99fff7cae7ea758d5ce39f9c7fab8d40d3a463ae0265e41f0a0c44 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_bc9236367d99fff7cae7ea758d5ce39f9c7fab8d40d3a463ae0265e41f0a0c44->enter($__internal_bc9236367d99fff7cae7ea758d5ce39f9c7fab8d40d3a463ae0265e41f0a0c44_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        $__internal_d10bb35d41adf1b1751efab0c08d439b4838227ec5084b63f337cbf5e886ffca = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_d10bb35d41adf1b1751efab0c08d439b4838227ec5084b63f337cbf5e886ffca->enter($__internal_d10bb35d41adf1b1751efab0c08d439b4838227ec5084b63f337cbf5e886ffca_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        echo "Project Rider";
        
        $__internal_d10bb35d41adf1b1751efab0c08d439b4838227ec5084b63f337cbf5e886ffca->leave($__internal_d10bb35d41adf1b1751efab0c08d439b4838227ec5084b63f337cbf5e886ffca_prof);

        
        $__internal_bc9236367d99fff7cae7ea758d5ce39f9c7fab8d40d3a463ae0265e41f0a0c44->leave($__internal_bc9236367d99fff7cae7ea758d5ce39f9c7fab8d40d3a463ae0265e41f0a0c44_prof);

    }

    // line 11
    public function block_stylesheets($context, array $blocks = array())
    {
        $__internal_10f8485a9cab1d18987cc45990ee448008fb6e6aa7b33d8699df13e69a081af3 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_10f8485a9cab1d18987cc45990ee448008fb6e6aa7b33d8699df13e69a081af3->enter($__internal_10f8485a9cab1d18987cc45990ee448008fb6e6aa7b33d8699df13e69a081af3_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        $__internal_fd3dcf6c56450570b73e17f540010c6061d2cde0887efd578d8501bf8bbc8831 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_fd3dcf6c56450570b73e17f540010c6061d2cde0887efd578d8501bf8bbc8831->enter($__internal_fd3dcf6c56450570b73e17f540010c6061d2cde0887efd578d8501bf8bbc8831_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "stylesheets"));

        // line 12
        echo "        <link rel=\"stylesheet\" href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/reset.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 13
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/style.css"), "html", null, true);
        echo "\">
        <link rel=\"stylesheet\" href=\"";
        // line 14
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("css/create-style.css"), "html", null, true);
        echo "\">
    ";
        
        $__internal_fd3dcf6c56450570b73e17f540010c6061d2cde0887efd578d8501bf8bbc8831->leave($__internal_fd3dcf6c56450570b73e17f540010c6061d2cde0887efd578d8501bf8bbc8831_prof);

        
        $__internal_10f8485a9cab1d18987cc45990ee448008fb6e6aa7b33d8699df13e69a081af3->leave($__internal_10f8485a9cab1d18987cc45990ee448008fb6e6aa7b33d8699df13e69a081af3_prof);

    }

    // line 19
    public function block_body_id($context, array $blocks = array())
    {
        $__internal_dd9c42d19ac767df740306b69d3eb6a40647becbdb55982efa142486cdc982f4 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_dd9c42d19ac767df740306b69d3eb6a40647becbdb55982efa142486cdc982f4->enter($__internal_dd9c42d19ac767df740306b69d3eb6a40647becbdb55982efa142486cdc982f4_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        $__internal_c8a627548824a4bb6d37e77889d6e8f8e7bf564ae0f9546f52f5e2d466b68655 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_c8a627548824a4bb6d37e77889d6e8f8e7bf564ae0f9546f52f5e2d466b68655->enter($__internal_c8a627548824a4bb6d37e77889d6e8f8e7bf564ae0f9546f52f5e2d466b68655_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body_id"));

        
        $__internal_c8a627548824a4bb6d37e77889d6e8f8e7bf564ae0f9546f52f5e2d466b68655->leave($__internal_c8a627548824a4bb6d37e77889d6e8f8e7bf564ae0f9546f52f5e2d466b68655_prof);

        
        $__internal_dd9c42d19ac767df740306b69d3eb6a40647becbdb55982efa142486cdc982f4->leave($__internal_dd9c42d19ac767df740306b69d3eb6a40647becbdb55982efa142486cdc982f4_prof);

    }

    // line 20
    public function block_body($context, array $blocks = array())
    {
        $__internal_f3bf6a1b4f475b431205974d45d7479ae75865125465913e8d4dd9e5bf225d9f = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_f3bf6a1b4f475b431205974d45d7479ae75865125465913e8d4dd9e5bf225d9f->enter($__internal_f3bf6a1b4f475b431205974d45d7479ae75865125465913e8d4dd9e5bf225d9f_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        $__internal_88eef70c5372724133d30bd1548dbe68a52ba8ebf48f0a06fd4ca4cfb2208af7 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_88eef70c5372724133d30bd1548dbe68a52ba8ebf48f0a06fd4ca4cfb2208af7->enter($__internal_88eef70c5372724133d30bd1548dbe68a52ba8ebf48f0a06fd4ca4cfb2208af7_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 21
        echo "    ";
        $this->displayBlock('main', $context, $blocks);
        
        $__internal_88eef70c5372724133d30bd1548dbe68a52ba8ebf48f0a06fd4ca4cfb2208af7->leave($__internal_88eef70c5372724133d30bd1548dbe68a52ba8ebf48f0a06fd4ca4cfb2208af7_prof);

        
        $__internal_f3bf6a1b4f475b431205974d45d7479ae75865125465913e8d4dd9e5bf225d9f->leave($__internal_f3bf6a1b4f475b431205974d45d7479ae75865125465913e8d4dd9e5bf225d9f_prof);

    }

    public function block_main($context, array $blocks = array())
    {
        $__internal_2bb0d260b69bcdb0266a67944c6d772eb39aa3a67950087c7691938ef25b8f07 = $this->env->getExtension("Symfony\\Bundle\\WebProfilerBundle\\Twig\\WebProfilerExtension");
        $__internal_2bb0d260b69bcdb0266a67944c6d772eb39aa3a67950087c7691938ef25b8f07->enter($__internal_2bb0d260b69bcdb0266a67944c6d772eb39aa3a67950087c7691938ef25b8f07_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        $__internal_ec06e25192cdf4fe7bd939d65e75efee5ee940df7117932346bd309ff13188c9 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_ec06e25192cdf4fe7bd939d65e75efee5ee940df7117932346bd309ff13188c9->enter($__internal_ec06e25192cdf4fe7bd939d65e75efee5ee940df7117932346bd309ff13188c9_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "main"));

        
        $__internal_ec06e25192cdf4fe7bd939d65e75efee5ee940df7117932346bd309ff13188c9->leave($__internal_ec06e25192cdf4fe7bd939d65e75efee5ee940df7117932346bd309ff13188c9_prof);

        
        $__internal_2bb0d260b69bcdb0266a67944c6d772eb39aa3a67950087c7691938ef25b8f07->leave($__internal_2bb0d260b69bcdb0266a67944c6d772eb39aa3a67950087c7691938ef25b8f07_prof);

    }

    public function getTemplateName()
    {
        return "base.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  141 => 21,  132 => 20,  115 => 19,  103 => 14,  99 => 13,  94 => 12,  85 => 11,  67 => 10,  55 => 23,  53 => 20,  49 => 19,  42 => 16,  40 => 11,  36 => 10,  30 => 6,);
    }

    /** @deprecated since 1.27 (to be removed in 2.0). Use getSourceContext() instead */
    public function getSource()
    {
        @trigger_error('The '.__METHOD__.' method is deprecated since version 1.27 and will be removed in 2.0. Use getSourceContext() instead.', E_USER_DEPRECATED);

        return $this->getSourceContext()->getCode();
    }

    public function getSourceContext()
    {
        return new Twig_Source("{#
   This is the base template used as the application layout which contains the
   common elements and decorates all the other templates.
   See http://symfony.com/doc/current/book/templating.html#template-inheritance-and-layouts
#}
<!DOCTYPE html>
<html lang=\"en-US\">
<head>
    <meta charset=\"UTF-8\"/>
    <title>{% block title %}Project Rider{% endblock %}</title>
    {% block stylesheets %}
        <link rel=\"stylesheet\" href=\"{{ asset('css/reset.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/style.css') }}\">
        <link rel=\"stylesheet\" href=\"{{ asset('css/create-style.css') }}\">
    {% endblock %}
    <link rel=\"icon\" type=\"image/x-icon\" href=\"{{ asset('favicon.ico') }}\"/>
</head>

<body id=\"{% block body_id %}{% endblock %}\">
{% block body %}
    {% block main %}{% endblock %}
{% endblock %}
</body>
</html>
", "base.html.twig", "C:\\Users\\User\\Desktop\\Rider\\PHP-Skeleton\\app\\Resources\\views\\base.html.twig");
    }
}

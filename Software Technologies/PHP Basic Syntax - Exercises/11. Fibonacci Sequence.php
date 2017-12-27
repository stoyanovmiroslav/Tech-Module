<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
    <form>
        N: <input type="text" name="num" />
        <input type="submit" />
    </form>
    <?php
    if(isset($_GET['num'])){
        $a = 0;
        $b = 1;

        $num = intval($_GET['num']);

        for ($i = 0; $i <= $num; $i++){
            $c = $a + $b;
            $b = $a;
            $a = $c;
            echo ($c . " ");
        }
    }
    ?>
</body>
</html>
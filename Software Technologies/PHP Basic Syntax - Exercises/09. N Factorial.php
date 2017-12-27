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
        $fact = 1;
        $num = intval($_GET['num']);
        for ($i = 2; $i <= $num; $i++){
            $fact = $fact * $i ;
        }
        echo $fact . " ";
    }
    ?>
</body>
</html>
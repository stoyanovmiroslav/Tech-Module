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
        $num = intval($_GET['num']);
        $arr = [1, 1, 2];

        for ($i = 3; $i < $num; $i++){
            $arr[$i] =  $arr[$i-1] +  $arr[$i-2] + $arr[$i-3];
        }
        for ($i = 0; $i < $num; $i++){
            echo ($arr[$i] . " ");
        }
    }
    ?>
</body>
</html>
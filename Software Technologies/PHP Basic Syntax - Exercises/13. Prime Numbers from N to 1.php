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
    if(isset($_GET['num'])) {
        $number = intval($_GET['num']);
        for($num = $number; $num > 0; $num--) {
            if(isPrime($num)){
                echo $num . " ";
            };
        }
    }
    function isPrime($num)
    {
        if ($num == 1)
            return false;
        if ($num == 2)
            return true;
        if ($num % 2 == 0) {
            return false;
        }
        $ceil = ceil(sqrt($num));
        for ($i = 3; $i <= $ceil; $i = $i + 2) {
            if ($num % $i == 0)
                return false;
        }
        return true;
    }
    ?>
</body>
</html>



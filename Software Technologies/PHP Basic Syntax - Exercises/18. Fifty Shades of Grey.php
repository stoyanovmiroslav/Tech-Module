<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        div {
            display: inline-block;
            margin: 5px;
            width: 20px;
            height: 20px;
        }
    </style>
</head>
<body>
<?php
$color = 0;
for ($j = 0; $j < 5; $j++) {
    for ($i = 0; $i < 10; $i++) {
        echo "<div style='background-color: RGB($color, $color, $color)'></div>";
        $color += 5;
    }
    $color += 1;
    echo "<br>". "\n\r";
}
?>
</body>
</html>

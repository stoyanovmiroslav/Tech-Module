<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<?php
for ($i = 0; $i < 5; $i++){
    echo "<button style='background-color: blue'>1</button>";
}
echo "\n\r<br>";
for ($j = 0; $j < 3; $j++) {
    for ($i = 0; $i < 5; $i++) {
        if($i == 0){
            echo "<button style='background-color: blue'>1</button>";
        }else{
            echo "<button>0</button>";
        }
    }
    echo "\n\r<br>";
}
for ($i = 0; $i < 5; $i++){
    echo "<button style='background-color: blue'>1</button>";
}
echo "\n\r<br>";
for ($j = 0; $j < 3; $j++) {
    for ($i = 0; $i < 5; $i++) {
        if($i == 4){
            echo "<button style='background-color: blue'>1</button>";
        }else{
            echo "<button>0</button>";
        }
    }
    echo "\n\r<br>";
}
for ($i = 0; $i < 5; $i++){
    echo "<button style='background-color: blue'>1</button>";
}
?>
</body>
</html>


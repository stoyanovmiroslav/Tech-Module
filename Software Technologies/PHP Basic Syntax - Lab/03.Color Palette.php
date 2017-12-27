<link rel="stylesheet" href="styles/styles.css">

<?php
for ($i = 0; $i <= 255; $i = $i + 51) {
    for ($j = 0; $j <= 255; $j = $j + 51) {
        for ($k = 0; $k <= 255; $k = $k + 51) {
            $color = "rgb($i, $j, $k)";
            echo "\t<div style='background:$color'>$color</div>";
        }
    }
}
?>
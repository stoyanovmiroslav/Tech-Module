<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
	<style>
		table * {
			border: 1px solid black;
			width: 50px;
			height: 50px;
		}
    </style>
</head>
<body>
<table>
    <tr>
        <td>
            Red
        </td>
        <td>
            Green
        </td>
        <td>
            Blue
        </td>
    </tr>
    <?php
    $red = 0;
    $green = 0;
    $blue = 0;
    for ($i = 0; $i < 5; $i++){
        echo "<tr>";
        for ($j = 0; $j < 3; $j++){
            if($j == 0){
                $red += 51;
                echo "<td style='background-color: RGB($red, 0, 0)'></td>";
            }
            if($j == 1){
                $green += 51;
                echo "<td style='background-color: RGB(0, $green, 0)'></td>";
            }
            if ($j == 2){
                $blue += 51;
                echo "<td style='background-color: RGB(0, 0, $blue)'></td>";
            }
        }
        echo "</tr>";
    }
    ?>
</table>
</body>
</html>

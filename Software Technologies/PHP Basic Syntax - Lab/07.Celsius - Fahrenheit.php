<form>
    Celsius: <input type="text" name="cel" />
    <input type="submit" value="Convert">
    <?php
    if(isset($_GET['cel'])){
        $cel = $_GET['cel'];
        $fah = $cel * 1.8 + 32;
        echo ("$cel &deg;C = $fah &deg;F");
    }
    ?>
</form>
<form>
    Fahrenheit: <input type="text" name="fah" />
    <input type="submit" value="Convert">
    <?php
    if(isset($_GET['fah'])){
        $fah = $_GET['fah'];
        $cel = ($fah - 32) / 1.8;
        echo ("$fah &deg;F = $cel &deg;C");
    }
    ?>
</form>

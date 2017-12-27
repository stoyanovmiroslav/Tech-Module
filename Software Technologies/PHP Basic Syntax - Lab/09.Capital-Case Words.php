<?php $upperWords = array();
if (isset($_GET['text'])) {
    $input = $_GET['text'];
    $items = array_filter(preg_split('/[^a-z0-9]/i', $input));

    foreach ($items as $item) {
        if (ctype_upper($item)) {
            $upperWords[] = $item;
        }
    }
}
?>

<form>
    <textarea rows="10" name="text"><?php
        echo implode(', ', $upperWords);
        ?>
    </textarea> <br>
    <input type="submit" value="Extract">
</form>
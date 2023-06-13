<html lang='en'>
    <head>
        <title>PHP Array Functions</title>
    </head>
    <body>
        <?php
            // jumbled array of numbers
            $numbers = array(8,23,15,42,16,4);
        ?><br />
        Count: <?php echo count($numbers); ?><br />
        Max: <?php echo max($numbers); ?><br />
        Min: <?php echo min($numbers); ?><br />
        <br />
        In-place Sort: <?php sort($numbers); print_r($numbers); ?><br />
        Reversed: <?php rsort($numbers); print_r($numbers); ?><br />
        <br />
        Implode: <?php echo $num_string = implode(" * ", $numbers); ?><br />
        Explode: <?php print_r(explode(" * ", $num_string)); ?><br />
        <br />
        15 in array? <?php echo in_array(15, $numbers); // retiurn true or false ?><br />
        19 in array? <?php echo in_array(19, $numbers); // retiurn true or false ?><br />
    </body>
</html>
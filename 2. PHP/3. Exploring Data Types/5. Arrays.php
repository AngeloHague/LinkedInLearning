<html lang='en'>
    <head>
        <title>PHP Arrays</title>
    </head>
    <body>
        <?php
            // define array
            $empty_array = array();
            $numbers = array(4,8,15,16,23,42);
            // arrays are index-based and start at 0 (god bless)
            echo $numbers[0];
        ?><br />
        <?php
            // define mixed array
            $mixed = array(6,"fox","dog", array("x","y", "z"));
        ?>
        <?php echo $mixed[2]; ?><br />
        <pre>
            <?php echo print_r($mixed); ?><br />
        </pre>
        <?php echo $mixed[3][1]; ?><br />
        <?php $mixed[2] = "cat"; ?><br />
        <?php
            // if index doesnt exist, it will simply add to the array
            $mixed[4] = "mouse";
        ?><br />
        <?php
            // if index isnt specified, it will also add to the array
            $mixed[] = "horse";
        ?><br />
        <pre>
            <?php echo print_r($mixed); ?><br />
        </pre>
        <?php
            // PHP 5.4: short array
            $array = [1,2,3];
        ?>
        <pre>
            <?php echo print_r($array); ?><br />
        </pre>
    </body>
</html>
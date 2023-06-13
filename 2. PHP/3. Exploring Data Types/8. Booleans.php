<html lang='en'>
    <head>
        <title>PHP Booleans</title>
    </head>
    <body>
        <?php
            // Boolean assignment
            // can be lower or upper
            $result1 = true;
            $result2 = FALSE;
        ?>
        Result 1:<?php echo $result1; ?><br />
        Result 2: <?php echo $result2; ?><br />
        Is Result 2 Boolean? <?php echo is_bool($result2); ?><br />
        <?php
            $number = 3.14;
            if ( is_float($number) )
                echo "{$number} is a float."
        ?>
    </body>
</html>
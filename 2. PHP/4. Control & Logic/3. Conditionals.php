<html lang='en'>
    <head>
        <title>PHP Comparisons</title>
    </head>
    <body>
        <?php
            $a = 5;
            $b = 5;
            $c = 6;
            $d = 4;
            echo "A({$a}), B({$b}), C({$c}), D({$d})";
        ?>
        <br/>
        <?php
            // equal to
            if ($a == $b) {
                echo "a and b are equal";
            }
        ?>
        <br/>
        <?php
            // less than or equal to
            if ($b <= $c) {
                echo "b is less than or equal to c";
            }
        ?>
        <br/>
        <?php
            // greater than or equal to
            if ($c >= $d) {
                echo "c is greater than or equal to d";
            } 
        ?>
        <br/>
        <?php
            // less than or greater than
            if ($a <> $d) {
                echo "a is less than or greater than d";
            }
        ?>
        <br/>
        <?php
            // not equal to
            if ($a != $d) {
                echo "a is not equal to d";
            }
        ?>
        <br/>
        <?php
            // both conditions
            if ($a == $b && $a != $d) {
                echo "a is equal to b and not equal to d";
            }
        ?>
        <br/>
        <?php
            // either condition
            if ($a == $b || $a != $b) {
                echo "a either is or isnt equal to b";
            }
        ?>
    </body>
</html>
<html lang='en'>
    <head>
        <title>PHP Pointers</title>
    </head>
    <body>
        <?php
            $ages = array(4,8,15,16,23,42,65,82);
            // current: pointer value
            echo "1: " . current($ages) . "<br/>";
            // next: move pointer forword
            next($ages);
            echo "2: " . current($ages) . "<br/>";
            // next: move pointer forword
            next($ages);
            echo "3: " . current($ages) . "<br/>";
            // previous: move pointer back
            prev($ages);
            echo "4: " . current($ages) . "<br/>";
            // reset: move pointer to start
            reset($ages);
            echo "4: " . current($ages) . "<br/>";
            // end: move pointer to end
            end($ages);
            echo "5: " . current($ages) . "<br/>";
            // next: move pointer to past the end
            next($ages);
            echo "6: " . current($ages) . "<br/>";
        ?>
        <br />
        <?php
            reset($ages);
            while ($age = current($ages)) {
                echo $age . ", ";
                next($ages);
            }
            echo "FIN."
        ?>
    </body>
</html>
<html lang='en'>
    <head>
        <title>PHP While Loops</title>
    </head>
    <body>
        <?php
            $i = 1;
            // While loops
            while ($i <= 10) {
                // skip 5
                if ($i == 5) {
                    $i++;
                    continue;
                }
                echo $i;
                $i++; // increment by 1
            }
        ?>
    </body>
</html>
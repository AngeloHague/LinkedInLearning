<html lang='en'>
    <head>
        <title>PHP Loop Skipping</title>
    </head>
    <body>
        <?php
            $i = 1;
            // While loops
            while ($i <= 1000) {
                // skip 5
                if ($i == 5) {
                    $i++;
                    continue;
                }
                // end when i reaches 8
                if ($i == 8) {
                    break;
                }
                echo $i;
                $i++; // increment by 1
            }
        ?>
    </body>
</html>
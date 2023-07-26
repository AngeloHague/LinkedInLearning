<html lang='en'>
    <head>
        <title>PHP If Else Statements</title>
    </head>
    <body>
        <?php
            $a = 6;
            $b = 6;
            // typical ifelse
            // similar to js
            if ($a > $b) {
                echo "a is larger than b";
            } elseif ($b > $a) {
                echo "b is larger than a";
            } else {
                echo "a and b are equal";
            }
        ?>
        <br />
        <?php
            $numerator = 20;
            $denominator = 0;
            $result = 0;
            if ($denominator > 0) {
                $result = $numerator / $denominator;
            }
            echo "Result of {$numerator} / {$denominator} = {$result}";
        ?>
    </body>
</html>
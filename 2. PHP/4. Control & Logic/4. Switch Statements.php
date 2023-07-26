<html lang='en'>
    <head>
        <title>PHP Switch Statements</title>
    </head>
    <body>
        <?php
            $a = 5;
            switch($a) {
                case ($a > 5):
                    echo "a is greater than 5";
                    break;
                case ($a < 5):
                    echo "a is less than 5";
                    break;
                case ($a == 5):
                case ($a === 5):
                    echo "a is equal to 5";
                    break;
                default:
                    echo "a is not equal to, greater or less than 5";
                    break;
            }
        ?>
    </body>
</html>
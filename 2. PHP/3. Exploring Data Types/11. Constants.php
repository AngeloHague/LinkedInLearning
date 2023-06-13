<html lang='en'>
    <head>
        <title>PHP Constants</title>
    </head>
    <body>
        <?php
            // variable definition
            $max_width = 980;
            // Constant definition
            define("MAX_WIDTH", 980);
            echo MAX_WIDTH;
        ?><br />
        <?php
            // cannot change the val or redefine
            //MAX_WIDTH += 1;
            //echo MAX_WIDTH;
        ?>
    </body>
</html>
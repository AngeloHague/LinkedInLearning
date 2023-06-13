<html lang='en'>
    <head>
        <title>PHP Type Juggling and Casting</title>
    </head>
    <body>
        <h3>Type Juggling</h3>
        <?php
            // Type Juggling is when PHP automatically casts a variable to a different type

            // Type Casting is when the programmed explicitly casted to a different type:
            // settype($var, "integer")
            // or:
            // (integer) $var = 0;
            $count = "2 cats";
        ?>
        Type: <?php echo gettype($count); ?><br />
        Type: <?php
            // sloppy programming (throws warning):
            $count+=3;
            echo gettype($count);
        ?><br />
        Cats: <?php
            // less sloppy, no warning, but not perfect:
            echo $cats = "I have " . $count . "cats";
        ?><br />
        <h3>Type Casting</h3>
        <?php
            // in place:
            settype($count, "integer");
        ?>
        Count: <?php echo gettype($count); ?><br />

        <?php
            // out of place / new definition:
            $count2 = (string) $count;
        ?>
        Count: <?php echo gettype($count); ?><br />
        Count2: <?php echo gettype($count2); ?><br />
        <br />

        <?php
            $test1 = 3;
            $test2 = 3;
            settype($test1, "string"); // permanent change
            (string) $test2; // temporary
        ?>
        test1: <?php echo gettype($test1); ?><br />
        test2: <?php echo gettype($test2); ?><br />
    </body>
</html>
<html lang='en'>
    <head>
        <title>PHP Function Definition</title>
    </head>
    <body>
        <?php
            // hello js functions
            function say_hello($person) {
                echo "Hello {$person}!<br />";
            }
            say_hello("World");
            say_hello("Angelo");
            say_hello("there");
        ?>
        <br/>
        <?php
            // hello js functions
            // with multiple params
            function say_something($something, $target) {
                echo "{$something} {$target}!<br />";
            }
            say_something("Hello","World");
            say_something("Hi", "Angelo");
            say_something("Hey", "there");
        ?>
        <br/>
        <?php
            // hello js functions
            // with default params
            function say_something_extra($something, $target, $punctuation='!') {
                echo "{$something} {$target}{$punctuation}<br />";
            }
            say_something_extra("Hello","World");
            say_something_extra("Hi", "Angelo",'.');
            say_something_extra("Hey", "there","...");
        ?>
    </body>
</html>
<html lang='en'>
    <head>
        <title>PHP Scope</title>
    </head>
    <body>
        <?php
            // global scope
            $bar = 'out';
            echo $bar . '<br/>';
            
            // local scope
            function foo() {
                $bar = 'in';
                return($bar);
            }
            echo foo() . '<br/>';

            // mixing scopes
            function foo_bar($bar) {
                return($bar);
            }
            echo foo_bar($bar) . '<br/>';

            // without passing
            function bar_foo() {
                return($bar);
            }
            echo bar_foo($bar) . '<br/>';
        ?>
    </body>
</html>
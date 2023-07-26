<html lang='en'>
    <head>
        <title>PHP Function with Returns</title>
    </head>
    <body>
        <?php
            // return from function
            function add($a, $b) {
                $sum = $a + $b;
                return($sum);
            }

            // get result and echo
            $result = add(3,4);
            echo "3+4={$result}";
        ?>
        <br />
        <?php
            // return from function
            function checkNumber($n) {
                // ternary operator
                $isEven = ($n % 2) ? false : true;
                $isPrime = true;
                for ($i = 2; $i <= $n; $i++) {
                    // skip self
                    if ($i == $n) {
                        continue;
                    }
                    if ($n % $i == 0) {
                        $isPrime = false;
                        break;
                    }
                }
                return array(
                    "isEven" => $isEven,
                    "isPrime" => $isPrime
                );
            }

            // get result and echo
            $n = 17;
            $result = checkNumber($n);
            echo "Is {$n}; even, a prime number?<br/>";
            echo var_export($result)
        ?>
    </body>
</html>
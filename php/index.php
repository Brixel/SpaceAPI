<?php
/**
 * Step 1: Require the Slim Framework
 *
 * If you are not using Composer, you need to require the
 * Slim Framework and register its PSR-0 autoloader.
 *
 * If you are using Composer, you can skip this step.
 */
require 'Slim/Slim.php';

\Slim\Slim::registerAutoloader();

/**
 * Step 2: Instantiate a Slim application
 *
 * This example instantiates a Slim application using
 * its default settings. However, you will usually configure
 * your Slim application now by passing an associative array
 * of setting names and values into the application constructor.
 */
$app = new \Slim\Slim();

/**
 * Step 3: Define the Slim application routes
 *
 * Here we define several Slim application routes that respond
 * to appropriate HTTP request methods. In this example, the second
 * argument for `Slim::get`, `Slim::post`, `Slim::put`, `Slim::patch`, and `Slim::delete`
 * is an anonymous function.
 */

// GET route
$app->get(
    '/',
    function () {
        $spaceURL = "https://spaceapi.net/new/space/brixel/status/json";
        $jsonData = json_decode(file_get_contents($spaceURL));
        $state = $jsonData->state->open;
        
        if($state){
            echo "<div style='background-color: #00FF00;
    height: 100%;
    width: 100%;'>";
        }else{
            echo "<div style='background-color: #FF0000;
    height: 100%;
    width: 100%;'>";
        }
    }
);

// POST route
$app->get(
    '/close',
    function () {
        $headers = array();
        $key = "";
        $sensors = "sensors=".urlencode('{"state":{"open":false}}')."&key=".$key;
        echo "Sensor data:<br />";
        echo $sensors."<br />";;
        echo "Starting CURL<br />";
        $ch = curl_init();
        curl_setopt($ch, CURLOPT_URL,            "https://spaceapi.net/new/space/brixel/sensor/set");
        curl_setopt($ch, CURLOPT_POST,           TRUE);
        curl_setopt($ch, CURLOPT_POSTFIELDS,     $sensors);
        curl_setopt($ch, CURLOPT_HTTPHEADER,     $headers);
        curl_setopt($ch, CURLOPT_RETURNTRANSFER, TRUE);
        echo "Preparing to execute CURL<br />";
        $result = curl_exec($ch);
        echo "CURL executed<br />";
        // Close connection
        curl_close($ch);
        echo "CURL closed<br />";
        print_r($result);
    }
);
$app->get(
    '/open',
    function () {
        $headers = array();
        $key = "hygub4Cf3Od8s0DV3GbT8..DOk1pE.vAeM2MGrKmiBhXyc7qwtsOq";
        $sensors = "sensors=".urlencode('{"state":{"open":true}}')."&key=".$key;
        echo "Sensor data:<br />";
        echo $sensors."<br />";;
        echo "Starting CURL<br />";
        $ch = curl_init();
        curl_setopt($ch, CURLOPT_URL,            "https://spaceapi.net/new/space/brixel/sensor/set");
        curl_setopt($ch, CURLOPT_POST,           TRUE);
        curl_setopt($ch, CURLOPT_POSTFIELDS,     $sensors);
        curl_setopt($ch, CURLOPT_HTTPHEADER,     $headers);
        curl_setopt($ch, CURLOPT_RETURNTRANSFER, TRUE);
        echo "Preparing to execute CURL<br />";
        $result = curl_exec($ch);
        echo "CURL executed<br />";
        // Close connection
        curl_close($ch);
        echo "CURL closed<br />";
        print_r($result);
    }
);
// PUT route
/*$app->put(
    '/put',
    function () {
        echo 'This is a PUT route';
    }
);

// PATCH route
$app->patch('/patch', function () {
    echo 'This is a PATCH route';
});

// DELETE route
$app->delete(
    '/delete',
    function () {
        echo 'This is a DELETE route';
    }
);*/

/**
 * Step 4: Run the Slim application
 *
 * This method should be called last. This executes the Slim application
 * and returns the HTTP response to the HTTP client.
 */
$app->run();

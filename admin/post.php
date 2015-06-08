<?php
$headers = array();
$key = "hygub4Cf3Od8s0DV3GbT8..DOk1pE.vAeM2MGrKmiBhXyc7qwtsOq";
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
//curl --data-urlencode sensors='' --data key=hygub4Cf3Od8s0DV3GbT8..DOk1pE.vAeM2MGrKmiBhXyc7qwtsOq 

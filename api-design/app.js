const express = require('express');
let bodyParser = require('body-parser');
const app = express();

const swaggerUi = require('swagger-ui-express');
const YAML = require('yamljs');
const swaggerDocument = YAML.load('./api/users/users.yaml');

app.use('/v1/users', swaggerUi.serve, swaggerUi.setup(swaggerDocument));

app.use(bodyParser.urlencoded({
    extended: true
}));
app.use(bodyParser.json());

var port = process.env.PORT || 3000;

app.get('/', (req, res) => res.sendFile(__dirname + '/index.html'));

app.listen(port, function () {
    console.log("Running RESTfulAPI on port " + port);
});
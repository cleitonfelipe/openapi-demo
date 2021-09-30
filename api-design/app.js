const express = require('express');
let bodyParser = require('body-parser');
const app = express();

const swaggerUi = require('swagger-ui-express');
const YAML = require('yamljs');
// const mergeYaml = require('merge-yaml');
// const fs = require('fs');
const swaggerDocument = YAML.load('./api/users/users.yaml');

app.use('/api/v1/users', swaggerUi.serve, swaggerUi.setup(swaggerDocument));

app.use(bodyParser.urlencoded({
    extended: true
}));
app.use(bodyParser.json());

// const basePath = './api/swagger/';
// const countryFiles = fs.readdirSync(`${basePath}`);
// const filesWithDir = countryFiles.map((file) => `${basePath}${file}`);
// const countriesYaml = mergeYaml(filesWithDir);
// const yamlStr = yaml.safeDump(countriesYaml);

// fs.writeFileSync(`${basePath}travelMerged.yaml`, yamlStr, 'utf8');


var port = process.env.PORT || 3000;

app.get('/', (req, res) => res.sendFile(__dirname + '/index.html'));

app.listen(port, function () {
    console.log("Running RESTfulAPI on port " + port);
});
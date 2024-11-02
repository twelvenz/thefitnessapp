const express = require('express');
const cors = require('cors');
const { MongoClient, ServerApiVersion } = require('mongodb');

const app = express();
const port = 5001; // or any port you want to use

app.use(cors());
app.use(express.json()); // for parsing application/json

const uri = "mongodb+srv://bob:qwerty1@cluster0.o3np0.mongodb.net/funfitnessApp?retryWrites=true&w=majority&appName=Cluster0";; // Use your actual URI
const client = new MongoClient(uri, {
    serverApi: {
        version: ServerApiVersion.v1,
        strict: true,
        deprecationErrors: true,
    }
});

async function run() {
    try {
        await client.connect();
        console.log("Connected to MongoDB!");

        const exercisesCollection = client.db("fitnessApp").collection("exercises");

        // Create a route to get all exercises
        app.get('/exercises', async (req, res) => {
            const exercises = await exercisesCollection.find().toArray();
            res.json(exercises);
        });

    } catch (error) {
        console.error(error);
    } finally {
        // Make sure to keep the client open
        // await client.close(); // Uncomment this if you want to close the connection on server stop
    }
}

run().catch(console.dir);

app.listen(port, () => {
    console.log(`Server is running on http://localhost:${port}`);
});

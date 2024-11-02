require('dotenv').config(); // Load environment variables from .env file
const { MongoClient, ServerApiVersion } = require('mongodb');

// Ensure your URI does not have angle brackets and replace <password> with your actual password
const uri = "mongodb+srv://bob:qwerty1@cluster0.o3np0.mongodb.net/funfitnessApp?retryWrites=true&w=majority&appName=Cluster0";

// Create a MongoClient with a MongoClientOptions object to set the Stable API version
const client = new MongoClient(uri, {
  serverApi: {
    version: ServerApiVersion.v1,
    strict: true,
    deprecationErrors: true,
  }
});

async function run() {
  try {
    // Connect the client to the server
    await client.connect();
    // Send a ping to confirm a successful connection
    await client.db("fitnessApp").command({ ping: 1 });
    console.log("Pinged your deployment. You successfully connected to MongoDB!");

    // Add your database logic here, for example, performing queries or inserting data.
  } catch (error) {
    console.error("Connection failed:", error);
  } finally {
    // Ensures that the client will close when you finish/error
    await client.close();
  }
}

run().catch(console.dir);

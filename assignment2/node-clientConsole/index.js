const axios = require("axios");

const API_URL = "https://squid-app-37wvn.ondigitalocean.app/i-know-who-you-are";

async function main() {
  try {
    const response = await axios.get(API_URL);
    console.log("Status:", response.status);
    console.log("Data:", JSON.stringify(response.data, null, 2));
  } catch (error) {
    console.error("Error:", error.message);
  }
}

main();

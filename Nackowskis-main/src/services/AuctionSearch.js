export const GetAuction = async (auctionId = "") => {
    const url = 'http://localhost:5145/api/Auktion/100/' + auctionId;
    try {
      const response = await fetch(url);
      const data = await response.json();
      return data;
    } catch (error) {
      console.error('Error in GetAuction:', error);
      throw error;
    }
  }
export default GetAuction;

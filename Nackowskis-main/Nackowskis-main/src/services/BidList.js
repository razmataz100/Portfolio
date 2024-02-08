export const fetchBidList = async (auctionId) => {
    const url = 'http://localhost:5145/api/bud/100/' + auctionId;
    try {
      const response = await fetch(url);
      const data = await response.json();

      return data;
    } catch (error) {
      console.error('Error in fetchBidList:', error);
      throw error;
    }
  }


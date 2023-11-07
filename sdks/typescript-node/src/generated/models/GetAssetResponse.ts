/* generated using openapi-typescript-codegen -- do no edit */
/* istanbul ignore file */
/* tslint:disable */
/* eslint-disable */

export type GetAssetResponse = {
  _id: string;
  name: string;
  network: GetAssetResponse.network;
  chainId: number;
  contractAddress: string;
  tokenId: string;
  description?: string | null;
  mintedAt?: string | null;
  standardImageUrl?: string | null;
  thumbnailImageUrl?: string | null;
  youtubeUrl?: string | null;
  backgroundColor?: string | null;
  externalUrl?: string | null;
  tokenUri: string;
  rarity?: GetAssetResponse.rarity | null;
  rarityScore?: number | null;
  normalizedRarityScore?: number | null;
  lastSoldTokenAmount?: string | null;
  lastSoldTokenCurrency?: GetAssetResponse.lastSoldTokenCurrency | null;
  indexerDataSyncedAt?: string | null;
  attributes?: Array<{
    type?: string | null;
    value?: string | null;
    rarity?: number | null;
    displayType?: string | null;
    maxValue?: number | null;
  }> | null;
  contract: {
    _id: string;
    chainId: number;
    address: string;
    network: GetAssetResponse.network;
    type: GetAssetResponse.type;
    name: string;
    slug: string;
    description?: string | null;
    currencySymbol: GetAssetResponse.currencySymbol;
    royalty?: number | null;
    royaltyAddress?: string | null;
    avatar: {
      src?: string | null;
      caption?: string | null;
    };
    header: {
      background?: {
        src?: string | null;
      } | null;
    };
  };
  listing?: {
    _id: string;
    nftId: string;
    contractId: string;
    userId: string;
    sellType: GetAssetResponse.sellType;
    quantity: number;
    tokenAddress: string;
    price?: string | null;
    startPrice?: string | null;
    endPrice?: string | null;
    startTime: string;
    endTime: string;
    expiresAt: string;
    platformFee: number;
    createdAt?: string | null;
    updatedAt?: string | null;
    currency: GetAssetResponse.currency;
    orderId?: string;
  } | null;
  ownershipByAddresses?: Array<{
    address: string;
    entityId?: string;
    quantity: number;
    user: {
      _id: string;
      isCreator: boolean;
      isRoyaltyOwner?: boolean | null;
      username?: string | null;
      profile?: {
        bio?: string | null;
        isVerified: boolean;
        profilePicture?: string | null;
        profilePictureUrl?: string | null;
        telegram?: string | null;
        twitter?: string | null;
        website?: string | null;
      } | null;
    };
  } | null> | null;
};

export namespace GetAssetResponse {

  export enum network {
    AVALANCHE = 'Avalanche',
    BEAM = 'Beam',
    ETHEREUM = 'Ethereum',
    POLYGON = 'Polygon',
  }

  export enum rarity {
    COMMON = 'Common',
    EXTREMELY_RARE = 'ExtremelyRare',
    RARE = 'Rare',
    UNCOMMON = 'Uncommon',
    VERY_RARE = 'VeryRare',
  }

  export enum lastSoldTokenCurrency {
    AVAX = 'Avax',
    BEAM = 'Beam',
    ETH = 'Eth',
    MATIC = 'Matic',
    MC = 'Mc',
    USDC = 'Usdc',
    USDT = 'Usdt',
    WAVAX = 'Wavax',
    WBEAM = 'Wbeam',
    WETH = 'Weth',
    WMATIC = 'Wmatic',
    WMC = 'Wmc',
  }

  export enum type {
    ERC721 = 'ERC721',
    ERC1155 = 'ERC1155',
  }

  export enum currencySymbol {
    AVAX = 'Avax',
    BEAM = 'Beam',
    ETH = 'Eth',
    MATIC = 'Matic',
    MC = 'Mc',
    USDC = 'Usdc',
    USDT = 'Usdt',
    WAVAX = 'Wavax',
    WBEAM = 'Wbeam',
    WETH = 'Weth',
    WMATIC = 'Wmatic',
    WMC = 'Wmc',
  }

  export enum sellType {
    ASCENDING_AUCTION = 'AscendingAuction',
    DESCENDING_AUCTION = 'DescendingAuction',
    FIXED_PRICE = 'FixedPrice',
    NOT_FOR_SALE = 'NotForSale',
  }

  export enum currency {
    AVAX = 'Avax',
    BEAM = 'Beam',
    ETH = 'Eth',
    MATIC = 'Matic',
    MC = 'Mc',
    USDC = 'Usdc',
    USDT = 'Usdt',
    WAVAX = 'Wavax',
    WBEAM = 'Wbeam',
    WETH = 'Weth',
    WMATIC = 'Wmatic',
    WMC = 'Wmc',
  }


}


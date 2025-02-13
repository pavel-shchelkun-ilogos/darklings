#if !DISABLE_PLAYFABENTITY_API
using PlayFab.EconomyModels;

namespace PlayFab.Events
{
    public class PlayFabEvents_Economy
    {
        public event PlayFabEvents.PlayFabRequestEvent<AddInventoryItemsRequest> OnEconomyAddInventoryItemsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<AddInventoryItemsResponse> OnEconomyAddInventoryItemsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<CreateDraftItemRequest> OnEconomyCreateDraftItemRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<CreateDraftItemResponse> OnEconomyCreateDraftItemResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<CreateUploadUrlsRequest> OnEconomyCreateUploadUrlsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<CreateUploadUrlsResponse> OnEconomyCreateUploadUrlsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<DeleteEntityItemReviewsRequest> OnEconomyDeleteEntityItemReviewsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<DeleteEntityItemReviewsResponse> OnEconomyDeleteEntityItemReviewsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<DeleteInventoryCollectionRequest> OnEconomyDeleteInventoryCollectionRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<DeleteInventoryCollectionResponse> OnEconomyDeleteInventoryCollectionResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<DeleteInventoryItemsRequest> OnEconomyDeleteInventoryItemsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<DeleteInventoryItemsResponse> OnEconomyDeleteInventoryItemsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<DeleteItemRequest> OnEconomyDeleteItemRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<DeleteItemResponse> OnEconomyDeleteItemResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<ExecuteInventoryOperationsRequest> OnEconomyExecuteInventoryOperationsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<ExecuteInventoryOperationsResponse> OnEconomyExecuteInventoryOperationsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<GetCatalogConfigRequest> OnEconomyGetCatalogConfigRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<GetCatalogConfigResponse> OnEconomyGetCatalogConfigResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<GetDraftItemRequest> OnEconomyGetDraftItemRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<GetDraftItemResponse> OnEconomyGetDraftItemResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<GetDraftItemsRequest> OnEconomyGetDraftItemsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<GetDraftItemsResponse> OnEconomyGetDraftItemsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<GetEntityDraftItemsRequest> OnEconomyGetEntityDraftItemsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<GetEntityDraftItemsResponse> OnEconomyGetEntityDraftItemsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<GetEntityItemReviewRequest> OnEconomyGetEntityItemReviewRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<GetEntityItemReviewResponse> OnEconomyGetEntityItemReviewResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<GetInventoryCollectionIdsRequest> OnEconomyGetInventoryCollectionIdsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<GetInventoryCollectionIdsResponse> OnEconomyGetInventoryCollectionIdsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<GetInventoryItemsRequest> OnEconomyGetInventoryItemsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<GetInventoryItemsResponse> OnEconomyGetInventoryItemsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<GetItemRequest> OnEconomyGetItemRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<GetItemResponse> OnEconomyGetItemResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<GetItemContainersRequest> OnEconomyGetItemContainersRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<GetItemContainersResponse> OnEconomyGetItemContainersResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<GetItemModerationStateRequest> OnEconomyGetItemModerationStateRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<GetItemModerationStateResponse> OnEconomyGetItemModerationStateResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<GetItemPublishStatusRequest> OnEconomyGetItemPublishStatusRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<GetItemPublishStatusResponse> OnEconomyGetItemPublishStatusResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<GetItemReviewsRequest> OnEconomyGetItemReviewsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<GetItemReviewsResponse> OnEconomyGetItemReviewsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<GetItemReviewSummaryRequest> OnEconomyGetItemReviewSummaryRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<GetItemReviewSummaryResponse> OnEconomyGetItemReviewSummaryResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<GetItemsRequest> OnEconomyGetItemsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<GetItemsResponse> OnEconomyGetItemsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<GetMicrosoftStoreAccessTokensRequest> OnEconomyGetMicrosoftStoreAccessTokensRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<GetMicrosoftStoreAccessTokensResponse> OnEconomyGetMicrosoftStoreAccessTokensResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<GetTransactionHistoryRequest> OnEconomyGetTransactionHistoryRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<GetTransactionHistoryResponse> OnEconomyGetTransactionHistoryResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<PublishDraftItemRequest> OnEconomyPublishDraftItemRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<PublishDraftItemResponse> OnEconomyPublishDraftItemResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<PurchaseInventoryItemsRequest> OnEconomyPurchaseInventoryItemsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<PurchaseInventoryItemsResponse> OnEconomyPurchaseInventoryItemsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<RedeemAppleAppStoreInventoryItemsRequest> OnEconomyRedeemAppleAppStoreInventoryItemsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<RedeemAppleAppStoreInventoryItemsResponse> OnEconomyRedeemAppleAppStoreInventoryItemsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<RedeemGooglePlayInventoryItemsRequest> OnEconomyRedeemGooglePlayInventoryItemsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<RedeemGooglePlayInventoryItemsResponse> OnEconomyRedeemGooglePlayInventoryItemsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<RedeemMicrosoftStoreInventoryItemsRequest> OnEconomyRedeemMicrosoftStoreInventoryItemsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<RedeemMicrosoftStoreInventoryItemsResponse> OnEconomyRedeemMicrosoftStoreInventoryItemsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<RedeemNintendoEShopInventoryItemsRequest> OnEconomyRedeemNintendoEShopInventoryItemsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<RedeemNintendoEShopInventoryItemsResponse> OnEconomyRedeemNintendoEShopInventoryItemsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<RedeemPlayStationStoreInventoryItemsRequest> OnEconomyRedeemPlayStationStoreInventoryItemsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<RedeemPlayStationStoreInventoryItemsResponse> OnEconomyRedeemPlayStationStoreInventoryItemsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<RedeemSteamInventoryItemsRequest> OnEconomyRedeemSteamInventoryItemsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<RedeemSteamInventoryItemsResponse> OnEconomyRedeemSteamInventoryItemsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<ReportItemRequest> OnEconomyReportItemRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<ReportItemResponse> OnEconomyReportItemResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<ReportItemReviewRequest> OnEconomyReportItemReviewRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<ReportItemReviewResponse> OnEconomyReportItemReviewResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<ReviewItemRequest> OnEconomyReviewItemRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<ReviewItemResponse> OnEconomyReviewItemResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<SearchItemsRequest> OnEconomySearchItemsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<SearchItemsResponse> OnEconomySearchItemsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<SetItemModerationStateRequest> OnEconomySetItemModerationStateRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<SetItemModerationStateResponse> OnEconomySetItemModerationStateResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<SubmitItemReviewVoteRequest> OnEconomySubmitItemReviewVoteRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<SubmitItemReviewVoteResponse> OnEconomySubmitItemReviewVoteResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<SubtractInventoryItemsRequest> OnEconomySubtractInventoryItemsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<SubtractInventoryItemsResponse> OnEconomySubtractInventoryItemsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<TakedownItemReviewsRequest> OnEconomyTakedownItemReviewsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<TakedownItemReviewsResponse> OnEconomyTakedownItemReviewsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<TransferInventoryItemsRequest> OnEconomyTransferInventoryItemsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<TransferInventoryItemsResponse> OnEconomyTransferInventoryItemsResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<UpdateCatalogConfigRequest> OnEconomyUpdateCatalogConfigRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<UpdateCatalogConfigResponse> OnEconomyUpdateCatalogConfigResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<UpdateDraftItemRequest> OnEconomyUpdateDraftItemRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<UpdateDraftItemResponse> OnEconomyUpdateDraftItemResultEvent;
        public event PlayFabEvents.PlayFabRequestEvent<UpdateInventoryItemsRequest> OnEconomyUpdateInventoryItemsRequestEvent;
        public event PlayFabEvents.PlayFabResultEvent<UpdateInventoryItemsResponse> OnEconomyUpdateInventoryItemsResultEvent;
    }
}
#endif

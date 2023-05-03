using System;

namespace PlayFab
{
	public enum PlayFabErrorCode
	{
		Unknown = 1,
		Success = 0,
		UnkownError = 500,
		InvalidParams = 1000,
		AccountNotFound,
		AccountBanned,
		InvalidUsernameOrPassword,
		InvalidTitleId,
		InvalidEmailAddress,
		EmailAddressNotAvailable,
		InvalidUsername,
		InvalidPassword,
		UsernameNotAvailable,
		InvalidSteamTicket,
		AccountAlreadyLinked,
		LinkedAccountAlreadyClaimed,
		InvalidFacebookToken,
		AccountNotLinked,
		FailedByPaymentProvider,
		CouponCodeNotFound,
		InvalidContainerItem,
		ContainerNotOwned,
		KeyNotOwned,
		InvalidItemIdInTable,
		InvalidReceipt,
		ReceiptAlreadyUsed,
		ReceiptCancelled,
		GameNotFound,
		GameModeNotFound,
		InvalidGoogleToken,
		UserIsNotPartOfDeveloper,
		InvalidTitleForDeveloper,
		TitleNameConflicts,
		UserisNotValid,
		ValueAlreadyExists,
		BuildNotFound,
		PlayerNotInGame,
		InvalidTicket,
		InvalidDeveloper,
		InvalidOrderInfo,
		RegistrationIncomplete,
		InvalidPlatform,
		UnknownError,
		SteamApplicationNotOwned,
		WrongSteamAccount,
		TitleNotActivated,
		RegistrationSessionNotFound,
		NoSuchMod,
		FileNotFound,
		DuplicateEmail,
		ItemNotFound,
		ItemNotOwned,
		ItemNotRecycleable,
		ItemNotAffordable,
		InvalidVirtualCurrency,
		WrongVirtualCurrency,
		WrongPrice,
		NonPositiveValue,
		InvalidRegion,
		RegionAtCapacity,
		ServerFailedToStart,
		NameNotAvailable,
		InsufficientFunds,
		InvalidDeviceID,
		InvalidPushNotificationToken,
		NoRemainingUses,
		InvalidPaymentProvider,
		PurchaseInitializationFailure,
		DuplicateUsername,
		InvalidBuyerInfo,
		NoGameModeParamsSet,
		BodyTooLarge,
		ReservedWordInBody,
		InvalidTypeInBody,
		InvalidRequest,
		ReservedEventName,
		InvalidUserStatistics,
		NotAuthenticated,
		StreamAlreadyExists,
		ErrorCreatingStream,
		StreamNotFound,
		InvalidAccount,
		PurchaseDoesNotExist = 1080,
		InvalidPurchaseTransactionStatus,
		APINotEnabledForGameClientAccess,
		NoPushNotificationARNForTitle,
		BuildAlreadyExists,
		BuildPackageDoesNotExist,
		CustomAnalyticsEventsNotEnabledForTitle = 1087,
		InvalidSharedGroupId,
		NotAuthorized,
		MissingTitleGoogleProperties,
		InvalidItemProperties,
		InvalidPSNAuthCode,
		InvalidItemId,
		PushNotEnabledForAccount,
		PushServiceError,
		ReceiptDoesNotContainInAppItems,
		ReceiptContainsMultipleInAppItems,
		InvalidBundleID,
		JavascriptException,
		InvalidSessionTicket,
		UnableToConnectToDatabase,
		InternalServerError = 1110,
		InvalidReportDate,
		ReportNotAvailable,
		DatabaseThroughputExceeded,
		InvalidGameTicket = 1115,
		ExpiredGameTicket,
		GameTicketDoesNotMatchLobby,
		LinkedDeviceAlreadyClaimed,
		DeviceAlreadyLinked,
		DeviceNotLinked,
		PartialFailure,
		PublisherNotSet,
		ServiceUnavailable,
		VersionNotFound,
		RevisionNotFound,
		InvalidPublisherId,
		DownstreamServiceUnavailable,
		APINotIncludedInTitleUsageTier,
		DAULimitExceeded,
		APIRequestLimitExceeded,
		InvalidAPIEndpoint,
		BuildNotAvailable,
		ConcurrentEditError,
		ContentNotFound,
		CharacterNotFound,
		CloudScriptNotFound,
		ContentQuotaExceeded,
		InvalidCharacterStatistics,
		PhotonNotEnabledForTitle,
		PhotonApplicationNotFound,
		PhotonApplicationNotAssociatedWithTitle,
		InvalidEmailOrPassword,
		FacebookAPIError,
		InvalidContentType,
		KeyLengthExceeded,
		DataLengthExceeded,
		TooManyKeys,
		FreeTierCannotHaveVirtualCurrency,
		MissingAmazonSharedKey,
		AmazonValidationError,
		InvalidPSNIssuerId,
		PSNInaccessible,
		ExpiredAuthToken,
		FailedToGetEntitlements,
		FailedToConsumeEntitlement,
		TradeAcceptingUserNotAllowed,
		TradeInventoryItemIsAssignedToCharacter,
		TradeInventoryItemIsBundle,
		TradeStatusNotValidForCancelling,
		TradeStatusNotValidForAccepting,
		TradeDoesNotExist,
		TradeCancelled,
		TradeAlreadyFilled,
		TradeWaitForStatusTimeout,
		TradeInventoryItemExpired,
		TradeMissingOfferedAndAcceptedItems,
		TradeAcceptedItemIsBundle,
		TradeAcceptedItemIsStackable,
		TradeInventoryItemInvalidStatus,
		TradeAcceptedCatalogItemInvalid,
		TradeAllowedUsersInvalid,
		TradeInventoryItemDoesNotExist,
		TradeInventoryItemIsConsumed,
		TradeInventoryItemIsStackable,
		TradeAcceptedItemsMismatch,
		InvalidKongregateToken,
		FeatureNotConfiguredForTitle,
		NoMatchingCatalogItemForReceipt,
		InvalidCurrencyCode,
		NoRealMoneyPriceForCatalogItem,
		TradeInventoryItemIsNotTradable,
		TradeAcceptedCatalogItemIsNotTradable,
		UsersAlreadyFriends,
		LinkedIdentifierAlreadyClaimed,
		CustomIdNotLinked,
		TotalDataSizeExceeded,
		DeleteKeyConflict,
		InvalidXboxLiveToken,
		ExpiredXboxLiveToken,
		ResettableStatisticVersionRequired,
		NotAuthorizedByTitle,
		NoPartnerEnabled,
		InvalidPartnerResponse,
		APINotEnabledForGameServerAccess,
		StatisticNotFound,
		StatisticNameConflict,
		StatisticVersionClosedForWrites,
		StatisticVersionInvalid,
		APIClientRequestRateLimitExceeded,
		InvalidJSONContent,
		InvalidDropTable,
		StatisticVersionAlreadyIncrementedForScheduledInterval,
		StatisticCountLimitExceeded,
		StatisticVersionIncrementRateExceeded,
		ContainerKeyInvalid,
		CloudScriptExecutionTimeLimitExceeded,
		NoWritePermissionsForEvent,
		CloudScriptFunctionArgumentSizeExceeded,
		CloudScriptAPIRequestCountExceeded,
		CloudScriptAPIRequestError,
		CloudScriptHTTPRequestError,
		InsufficientGuildRole,
		GuildNotFound,
		OverLimit,
		EventNotFound,
		InvalidEventField,
		InvalidEventName,
		CatalogNotConfigured,
		OperationNotSupportedForPlatform,
		SegmentNotFound,
		StoreNotFound,
		InvalidStatisticName,
		TitleNotQualifiedForLimit,
		InvalidServiceLimitLevel,
		ServiceLimitLevelInTransition,
		CouponAlreadyRedeemed,
		GameServerBuildSizeLimitExceeded,
		GameServerBuildCountLimitExceeded,
		VirtualCurrencyCountLimitExceeded,
		VirtualCurrencyCodeExists,
		TitleNewsItemCountLimitExceeded,
		InvalidTwitchToken,
		TwitchResponseError,
		ProfaneDisplayName,
		UserAlreadyAdded,
		InvalidVirtualCurrencyCode,
		VirtualCurrencyCannotBeDeleted,
		IdentifierAlreadyClaimed,
		IdentifierNotLinked,
		InvalidContinuationToken,
		ExpiredContinuationToken,
		InvalidSegment,
		InvalidSessionId,
		SessionLogNotFound,
		InvalidSearchTerm,
		TwoFactorAuthenticationTokenRequired,
		GameServerHostCountLimitExceeded,
		PlayerTagCountLimitExceeded,
		RequestAlreadyRunning,
		ActionGroupNotFound,
		MaximumSegmentBulkActionJobsRunning,
		NoActionsOnPlayersInSegmentJob,
		DuplicateStatisticName,
		ScheduledTaskNameConflict,
		ScheduledTaskCreateConflict,
		InvalidScheduledTaskName,
		InvalidTaskSchedule,
		SteamNotEnabledForTitle,
		LimitNotAnUpgradeOption,
		NoSecretKeyEnabledForCloudScript,
		TaskNotFound,
		TaskInstanceNotFound,
		InvalidIdentityProviderId,
		MisconfiguredIdentityProvider,
		InvalidScheduledTaskType,
		BillingInformationRequired,
		LimitedEditionItemUnavailable,
		InvalidAdPlacementAndReward,
		AllAdPlacementViewsAlreadyConsumed,
		GoogleOAuthNotConfiguredForTitle,
		GoogleOAuthError,
		UserNotFriend,
		InvalidSignature,
		InvalidPublicKey,
		GoogleOAuthNoIdTokenIncludedInResponse,
		StatisticUpdateInProgress,
		LeaderboardVersionNotAvailable,
		StatisticAlreadyHasPrizeTable = 1279,
		PrizeTableHasOverlappingRanks,
		PrizeTableHasMissingRanks,
		PrizeTableRankStartsAtZero,
		InvalidStatistic,
		ExpressionParseFailure,
		ExpressionInvokeFailure,
		ExpressionTooLong,
		DataUpdateRateExceeded,
		RestrictedEmailDomain,
		EncryptionKeyDisabled,
		EncryptionKeyMissing,
		EncryptionKeyBroken,
		NoSharedSecretKeyConfigured,
		SecretKeyNotFound,
		PlayerSecretAlreadyConfigured,
		APIRequestsDisabledForTitle,
		InvalidSharedSecretKey,
		PrizeTableHasNoRanks,
		ProfileDoesNotExist,
		ContentS3OriginBucketNotConfigured,
		InvalidEnvironmentForReceipt,
		EncryptedRequestNotAllowed,
		SignedRequestNotAllowed,
		RequestViewConstraintParamsNotAllowed,
		BadPartnerConfiguration,
		XboxBPCertificateFailure,
		XboxXASSExchangeFailure,
		InvalidEntityId,
		StatisticValueAggregationOverflow,
		EmailMessageFromAddressIsMissing,
		EmailMessageToAddressIsMissing,
		SmtpServerAuthenticationError,
		SmtpServerLimitExceeded,
		SmtpServerInsufficientStorage,
		SmtpServerCommunicationError,
		SmtpServerGeneralFailure,
		EmailClientTimeout,
		EmailClientCanceledTask,
		EmailTemplateMissing,
		InvalidHostForTitleId,
		EmailConfirmationTokenDoesNotExist,
		EmailConfirmationTokenExpired,
		AccountDeleted,
		PlayerSecretNotConfigured,
		InvalidSignatureTime,
		NoContactEmailAddressFound,
		InvalidAuthToken,
		AuthTokenDoesNotExist,
		AuthTokenExpired,
		AuthTokenAlreadyUsedToResetPassword,
		MembershipNameTooLong,
		MembershipNotFound,
		GoogleServiceAccountInvalid,
		GoogleServiceAccountParseFailure,
		EntityTokenMissing,
		EntityTokenInvalid,
		EntityTokenExpired,
		EntityTokenRevoked,
		InvalidProductForSubscription,
		XboxInaccessible,
		SubscriptionAlreadyTaken,
		SmtpAddonNotEnabled,
		APIConcurrentRequestLimitExceeded,
		XboxRejectedXSTSExchangeRequest,
		VariableNotDefined,
		TemplateVersionNotDefined,
		FileTooLarge,
		TitleDeleted,
		TitleContainsUserAccounts,
		TitleDeletionPlayerCleanupFailure,
		EntityFileOperationPending,
		NoEntityFileOperationPending,
		EntityProfileVersionMismatch,
		TemplateVersionTooOld,
		MembershipDefinitionInUse,
		PaymentPageNotConfigured,
		FailedLoginAttemptRateLimitExceeded,
		EntityBlockedByGroup,
		RoleDoesNotExist,
		EntityIsAlreadyMember,
		DuplicateRoleId,
		GroupInvitationNotFound,
		GroupApplicationNotFound,
		OutstandingInvitationAcceptedInstead,
		OutstandingApplicationAcceptedInstead,
		RoleIsGroupDefaultMember,
		RoleIsGroupAdmin,
		RoleNameNotAvailable,
		GroupNameNotAvailable,
		EmailReportAlreadySent,
		EmailReportRecipientBlacklisted,
		EventNamespaceNotAllowed,
		EventEntityNotAllowed,
		InvalidEntityType,
		NullTokenResultFromAad,
		InvalidTokenResultFromAad,
		NoValidCertificateForAad,
		InvalidCertificateForAad,
		DuplicateDropTableId,
		MultiplayerServerError,
		MultiplayerServerTooManyRequests,
		MultiplayerServerNoContent,
		MultiplayerServerBadRequest,
		MultiplayerServerUnauthorized,
		MultiplayerServerForbidden,
		MultiplayerServerNotFound,
		MultiplayerServerConflict,
		MultiplayerServerInternalServerError,
		MultiplayerServerUnavailable,
		ExplicitContentDetected,
		PIIContentDetected,
		InvalidScheduledTaskParameter,
		PerEntityEventRateLimitExceeded,
		TitleDefaultLanguageNotSet,
		EmailTemplateMissingDefaultVersion,
		FacebookInstantGamesIdNotLinked,
		InvalidFacebookInstantGamesSignature,
		FacebookInstantGamesAuthNotConfiguredForTitle,
		EntityProfileConstraintValidationFailed,
		TelemetryIngestionKeyPending,
		TelemetryIngestionKeyNotFound,
		StatisticTagRequired,
		StatisticTagInvalid,
		DataIntegrityError,
		VirtualCurrencyCannotBeSetToOlderVersion,
		VirtualCurrencyMustBeWithinIntegerRange,
		EmailTemplateInvalidSyntax,
		EmailTemplateMissingCallback,
		PushNotificationTemplateInvalidPayload,
		InvalidLocalizedPushNotificationLanguage,
		MissingLocalizedPushNotificationMessage,
		PushNotificationTemplateMissingPlatformPayload,
		PushNotificationTemplatePayloadContainsInvalidJson,
		PushNotificationTemplateContainsInvalidIosPayload,
		PushNotificationTemplateContainsInvalidAndroidPayload,
		PushNotificationTemplateIosPayloadMissingNotificationBody,
		PushNotificationTemplateAndroidPayloadMissingNotificationBody,
		PushNotificationTemplateNotFound,
		PushNotificationTemplateMissingDefaultVersion,
		PushNotificationTemplateInvalidSyntax,
		PushNotificationTemplateNoCustomPayloadForV1,
		MatchmakingEntityInvalid = 2001,
		MatchmakingPlayerAttributesInvalid,
		MatchmakingCreateRequestMissing,
		MatchmakingCreateRequestCreatorMissing,
		MatchmakingCreateRequestCreatorIdMissing,
		MatchmakingCreateRequestUserListMissing,
		MatchmakingCreateRequestGiveUpAfterInvalid,
		MatchmakingTicketIdMissing,
		MatchmakingMatchIdMissing,
		MatchmakingMatchIdIdMissing,
		MatchmakingQueueNameMissing,
		MatchmakingTitleIdMissing,
		MatchmakingTicketIdIdMissing,
		MatchmakingPlayerIdMissing,
		MatchmakingJoinRequestUserMissing,
		MatchmakingQueueConfigNotFound,
		MatchmakingMatchNotFound,
		MatchmakingTicketNotFound,
		MatchmakingCreateTicketServerIdentityInvalid,
		MatchmakingCreateTicketClientIdentityInvalid,
		MatchmakingGetTicketUserMismatch,
		MatchmakingJoinTicketServerIdentityInvalid,
		MatchmakingJoinTicketUserIdentityMismatch,
		MatchmakingCancelTicketServerIdentityInvalid,
		MatchmakingCancelTicketUserIdentityMismatch,
		MatchmakingGetMatchIdentityMismatch,
		MatchmakingPlayerIdentityMismatch,
		MatchmakingAlreadyJoinedTicket,
		MatchmakingTicketAlreadyCompleted,
		MatchmakingQueueNameInvalid,
		MatchmakingQueueConfigInvalid,
		MatchmakingMemberProfileInvalid,
		WriteAttemptedDuringExport,
		NintendoSwitchDeviceIdNotLinked,
		MatchmakingNotEnabled,
		MatchmakingGetStatisticsIdentityInvalid,
		MatchmakingStatisticsIdMissing,
		CannotEnableMultiplayerServersForTitle
	}
}

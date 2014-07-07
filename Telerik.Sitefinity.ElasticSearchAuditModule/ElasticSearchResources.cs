using System;
using System.Linq;
using Telerik.Sitefinity.Localization;
using Telerik.Sitefinity.Localization.Data;

namespace Telerik.Sitefinity.ElasticSearchAuditModule
{
    /// <summary>
    /// Localizable strings for the ElasticSearch module
    /// </summary>
    /// <remarks>
    /// You can use Sitefinity Thunder to edit this file.
    /// To do this, open the file's context menu and select Edit with Thunder.    ///    
    /// </remarks>
    /// <see cref="http://www.sitefinity.com/documentation/documentationarticles/developers-guide/how-to/how-to-import-events-from-facebook/creating-the-resources-class"/>
    [ObjectInfo("ElasticSearchResources", ResourceClassId = "ElasticSearchResources", Title = "ElasticSearchResourcesTitle", TitlePlural = "ElasticSearchResourcesTitlePlural", Description = "ElasticSearchResourcesDescription")]
    public class ElasticSearchResources : Resource
    {
        #region Construction
        /// <summary>
        /// Initializes new instance of <see cref="ElasticSearchResources"/> class with the default <see cref="ResourceDataProvider"/>.
        /// </summary>
        public ElasticSearchResources()
        {
        }
        
        #endregion

        #region Class Description
        /// <summary>
        /// ElasticSearch Resources
        /// </summary>
        [ResourceEntry("ElasticSearchResourcesTitle",
            Value = "ElasticSearch module labels",
            Description = "The title of this class.",
            LastModified = "2014.07.02")]
        public string ElasticSearchResourcesTitle
        {
            get
            {
                return this["ElasticSearchResourcesTitle"];
            }
        }

        /// <summary>
        /// ElasticSearch Resources Title plural
        /// </summary>
        [ResourceEntry("ElasticSearchResourcesTitlePlural",
            Value = "ElasticSearch module labels",
            Description = "The title plural of this class.",
            LastModified = "2014.07.02")]
        public string ElasticSearchResourcesTitlePlural
        {
            get
            {
                return this["ElasticSearchResourcesTitlePlural"];
            }
        }

        /// <summary>
        /// Contains localizable resources for ElasticSearch module.
        /// </summary>
        [ResourceEntry("ElasticSearchResourcesDescription",
            Value = "Contains localizable resources for ElasticSearch module.",
            Description = "The description of this class.",
            LastModified = "2014.07.02")]
        public string ElasticSearchResourcesDescription
        {
            get
            {
                return this["ElasticSearchResourcesDescription"];
            }
        }
        #endregion

        #region Labels
        /// <summary>
        /// word: Actions
        /// </summary>
        [ResourceEntry("ActionsLabel",
            Value = "Actions",
            Description = "word: Actions",
            LastModified = "2014.07.02")]
        public string ActionsLabel
        {
            get
            {
                return this["ActionsLabel"];
            }
        }

        /// <summary>
        /// Title of the link for closing the dialog and going back to the ElasticSearch module
        /// </summary>
        [ResourceEntry("BackToLabel",
            Value = "Go Back",
            Description = "Title of the link for closing the dialog and going back",
            LastModified = "2014.07.02")]
        public string BackToLabel
        {
            get
            {
                return this["BackToLabel"];
            }
        }

        /// <summary>
        /// word: Cancel
        /// </summary>
        [ResourceEntry("CancelLabel",
            Value = "Cancel",
            Description = "word: Cancel",
            LastModified = "2014.07.02")]
        public string CancelLabel
        {
            get
            {
                return this["CancelLabel"];
            }
        }

        /// <summary>
        /// word: Save
        /// </summary>
        /// <value>Save</value>
        [ResourceEntry("SaveLabel",
            Value = "Save",
            Description = "word: Save",
            LastModified = "2014.07.02")]
        public string SaveLabel
        {
            get
            {
                return this["SaveLabel"];
            }
        }

        /// <summary>
        /// phrase: Save changes
        /// </summary>
        [ResourceEntry("SaveChangesLabel",
            Value = "Save changes",
            Description = "phrase: Save changes",
            LastModified = "2014.07.02")]
        public string SaveChangesLabel
        {
            get
            {
                return this["SaveChangesLabel"];
            }
        }

        /// <summary>
        /// word: Delete
        /// </summary>
        [ResourceEntry("DeleteLabel",
            Value = "Delete",
            Description = "word: Delete",
            LastModified = "2014.07.02")]
        public string DeleteLabel
        {
            get
            {
                return this["DeleteLabel"];
            }
        }

        /// <summary>
        /// Phrase: Yes, delete these items
        /// </summary>
        /// <value>Yes, delete these items</value>
        [ResourceEntry("YesDeleteTheseItemsButton",
            Value = "Yes, delete these items",
            Description = "Phrase: Yes, delete these items",
            LastModified = "2014.07.02")]
        public string YesDeleteTheseItemsButton
        {
            get
            {
                return this["YesDeleteTheseItemsButton"];
            }
        }

        /// <summary>
        /// Text of the button that confirms deletion of an item.
        /// </summary>
        /// <value>Yes, delete this item</value>
        [ResourceEntry("YesDeleteThisItemButton",
            Value = "Yes, delete this item",
            Description = "Text of the button that confirms deletion of an item.",
            LastModified = "2014.07.02")]
        public string YesDeleteThisItemButton
        {
            get
            {
                return this["YesDeleteThisItemButton"];
            }
        }

        /// <summary>
        /// Phrase: items are about to be deleted. Continue?
        /// </summary>
        /// <value>items are about to be deleted. Continue?</value>
        [ResourceEntry("BatchDeleteConfirmationMessage",
            Value = "items are about to be deleted. Continue?",
            Description = "Phrase: items are about to be deleted. Continue?",
            LastModified = "2014.07.02")]
        public string BatchDeleteConfirmationMessage
        {
            get
            {
                return this["BatchDeleteConfirmationMessage"];
            }
        }

        /// <summary>
        /// word: Sort
        /// </summary>
        /// <value>Sort</value>
        [ResourceEntry("SortLabel",
            Value = "Sort",
            Description = "word: Sort",
            LastModified = "2014.07.02")]
        public string SortLabel
        {
            get
            {
                return this["SortLabel"];
            }
        }

        /// <summary>
        /// Phrase: Custom sorting
        /// </summary>
        /// <value>Custom sorting</value>
        [ResourceEntry("CustomSortingDialogHeader",
            Value = "Custom sorting",
            Description = "Phrase: Custom sorting",
            LastModified = "2014.07.02")]
        public string CustomSortingDialogHeader
        {
            get
            {
                return this["CustomSortingDialogHeader"];
            }
        }

        /// <summary>
        /// word: or
        /// </summary>
        /// <value>or</value>
        [ResourceEntry("OrLabel",
            Value = "or",
            Description = "word: or",
            LastModified = "2014.07.02")]
        public string OrLabel
        {
            get
            {
                return this["OrLabel"];
            }
        }

        /// <summary>
        /// Phrase: Sort by
        /// </summary>
        /// <value>Sort by</value>
        [ResourceEntry("SortByLabel",
            Value = "Sort by",
            Description = "Phrase: Sort by",
            LastModified = "2014.07.02")]
        public string SortByLabel
        {
            get
            {
                return this["SortByLabel"];
            }
        }

        /// <summary>
        /// word: Yes
        /// </summary>
        /// <value>Yes</value>
        [ResourceEntry("YesLabel",
            Value = "Yes",
            Description = "word: Yes",
            LastModified = "2013/06/26")]
        public string YesLabel
        {
            get
            {
                return this["YesLabel"];
            }
        }

        /// <summary>
        /// word: No
        /// </summary>
        /// <value>No</value>
        [ResourceEntry("NoLabel",
            Value = "No",
            Description = "word: No",
            LastModified = "2013/06/26")]
        public string NoLabel
        {
            get
            {
                return this["NoLabel"];
            }
        }
        #endregion

        #region ElasticSearchItems
        /// <summary>
        /// Messsage: PageTitle
        /// </summary>
        /// <value>Title for the ElasticSearchItem's page.</value>
        [ResourceEntry("ElasticSearchItemGroupPageTitle",
            Value = "ElasticSearchItem",
            Description = "The title of ElasticSearchItem's page.",
            LastModified = "2014.07.02")]
        public string ElasticSearchItemGroupPageTitle
        {
            get
            {
                return this["ElasticSearchItemGroupPageTitle"];
            }
        }

        /// <summary>
        /// Messsage: PageDescription
        /// </summary>
        /// <value>Description for the ElasticSearchItem's page.</value>
        [ResourceEntry("ElasticSearchItemGroupPageDescription",
            Value = "ElasticSearchItem",
            Description = "The description of ElasticSearchItem's page.",
            LastModified = "2014.07.02")]
        public string ElasticSearchItemGroupPageDescription
        {
            get
            {
                return this["ElasticSearchItemGroupPageDescription"];
            }
        }

        /// <summary>
        /// The URL name of ElasticSearchItem's page.
        /// </summary>
        [ResourceEntry("ElasticSearchItemGroupPageUrlName",
            Value = "ElasticSearch-ElasticSearchItem",
            Description = "The URL name of ElasticSearchItem's page.",
            LastModified = "2014.07.02")]
        public string ElasticSearchItemGroupPageUrlName
        {
            get
            {
                return this["ElasticSearchItemGroupPageUrlName"];
            }
        }

        /// <summary>
        /// Message displayed to user when no elasticSearchItems exist in the system
        /// </summary>
        /// <value>No elasticSearchItems have been created yet</value>
        [ResourceEntry("NoElasticSearchItemsCreatedMessage",
            Value = "No elasticSearchItems have been created yet",
            Description = "Message displayed to user when no elasticSearchItems exist in the system",
            LastModified = "2014.07.02")]
        public string NoElasticSearchItemsCreatedMessage
        {
            get
            {
                return this["NoElasticSearchItemsCreatedMessage"];
            }
        }

        /// <summary>
        /// Title of the button for creating a new elasticSearchItem
        /// </summary>
        /// <value>Create a elasticSearchItem</value>
        [ResourceEntry("CreateAElasticSearchItem",
            Value = "Create a elasticSearchItem",
            Description = "Title of the button for creating a new elasticSearchItem",
            LastModified = "2014.07.02")]
        public string CreateAElasticSearchItem
        {
            get
            {
                return this["CreateAElasticSearchItem"];
            }
        }

        /// <summary>
        /// Label for editing a new elasticSearchItem
        /// </summary>
        /// <value>Create a elasticSearchItem</value>
        [ResourceEntry("EditAElasticSearchItem",
            Value = "Edit a elasticSearchItem",
            Description = "Label for editing a new elasticSearchItem",
            LastModified = "2014.07.02")]
        public string EditAElasticSearchItem
        {
            get
            {
                return this["EditAElasticSearchItem"];
            }
        }

        /// <summary>
        /// ElasticSearchItem Title.
        /// </summary>
        /// <value>Title</value>
        [ResourceEntry("ElasticSearchItemTitleLabel",
            Value = "Title",
            Description = "ElasticSearchItem Title.",
            LastModified = "2014.07.02")]
        public string ElasticSearchItemTitleLabel
        {
            get
            {
                return this["ElasticSearchItemTitleLabel"];
            }
        }

        /// <summary>
        /// ElasticSearchItem Title description.
        /// </summary>
        /// <value>Enter the item's title (required)</value>
        [ResourceEntry("ElasticSearchItemTitleDescription",
            Value = "Enter the item's title (required)",
            Description = "ElasticSearchItem Title description.",
            LastModified = "2014.07.02")]
        public string ElasticSearchItemTitleDescription
        {
            get
            {
                return this["ElasticSearchItemTitleDescription"];
            }
        }

        /// <summary>
        /// Error message displayed if the user does not enter elasticSearchItem Title.
        /// </summary>
        [ResourceEntry("ElasticSearchItemTitleCannotBeEmpty",
            Value = "The Title of the elasticSearchItem cannot be empty.",
            Description = "Error message displayed if the user does not enter elasticSearchItem Title.",
            LastModified = "2014.07.02")]
        public string ElasticSearchItemTitleCannotBeEmpty
        {
            get
            {
                return this["ElasticSearchItemTitleCannotBeEmpty"];
            }
        }

        /// <summary>
        /// Error message displayed if the user enters too long Title.
        /// </summary>
        /// <value>Title value is too long. Maximum allowed is 255 characters.</value>
        [ResourceEntry("ElasticSearchItemTitleInvalidLength",
            Value = "Title value is too long. Maximum allowed is 255 characters.",
            Description = "Error message displayed if the user enters too long Title.",
            LastModified = "2014.07.02")]
        public string ElasticSearchItemTitleInvalidLength
        {
            get
            {
                return this["ElasticSearchItemTitleInvalidLength"];
            }
        }

        /// <summary>
        /// Message displayed to user when deleting a user elasticSearchItem.
        /// </summary>
        [ResourceEntry("DeleteElasticSearchItemConfirmationMessage",
            Value = "Are you sure you want to delete this elasticSearchItem?",
            Description = "Message displayed to user when deleting a user elasticSearchItem.",
            LastModified = "2014.07.02")]
        public string DeleteElasticSearchItemConfirmationMessage
        {
            get
            {
                return this["DeleteElasticSearchItemConfirmationMessage"];
            }
        }

        /// <summary>
        /// phrase: Create this elasticSearchItem
        /// </summary>
        [ResourceEntry("CreateThisElasticSearchItemButton",
            Value = "Create this elasticSearchItem",
            Description = "phrase: Create this elasticSearchItem",
            LastModified = "2014.07.02")]
        public string CreateThisElasticSearchItemButton
        {
            get
            {
                return this["CreateThisElasticSearchItemButton"];
            }
        }

        /// <summary>
        /// The URL name of ElasticSearchItem's page.
        /// </summary>
        /// <value>ElasticSearchItemMasterPageUrl</value>
        [ResourceEntry("ElasticSearchItemMasterPageUrl",
            Value = "ElasticSearchItemMasterPageUrl",
            Description = "The URL name of ElasticSearchItem's page.",
            LastModified = "2014.07.02")]
        public string ElasticSearchItemMasterPageUrl
        {
            get
            {
                return this["ElasticSearchItemMasterPageUrl"];
            }
        }
        #endregion
    }
}
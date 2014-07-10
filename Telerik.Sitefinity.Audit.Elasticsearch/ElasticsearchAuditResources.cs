using System;
using System.Linq;
using Telerik.Sitefinity.Localization;

namespace Telerik.Sitefinity.Audit.Elasticsearch
{
    /// <summary>
    /// Localizable strings for the Elasticsearch module
    /// </summary>
    /// <remarks>
    /// You can use Sitefinity Thunder to edit this file.
    /// To do this, open the file's context menu and select Edit with Thunder.    ///    
    /// </remarks>
    /// <see cref="http://www.sitefinity.com/documentation/documentationarticles/developers-guide/how-to/how-to-import-events-from-facebook/creating-the-resources-class"/>
    [ObjectInfo("ElasticsearchResources", ResourceClassId = "ElasticsearchResources", Title = "ElasticsearchResourcesTitle", TitlePlural = "ElasticsearchResourcesTitlePlural", Description = "ElasticsearchResourcesDescription")]
    public class ElasticsearchAuditResources : Resource
    {
        #region Construction
        /// <summary>
        /// Initializes new instance of <see cref="ElasticsearchAuditResources"/> class with the default <see cref="ResourceDataProvider"/>.
        /// </summary>
        public ElasticsearchAuditResources()
        {
        }
        
        #endregion

        #region Class Description
        /// <summary>
        /// Elasticsearch Resources
        /// </summary>
        [ResourceEntry("ElasticsearchResourcesTitle",
            Value = "Elasticsearch module labels",
            Description = "The title of this class.",
            LastModified = "2014.07.02")]
        public string ElasticsearchResourcesTitle
        {
            get
            {
                return this["ElasticsearchResourcesTitle"];
            }
        }

        /// <summary>
        /// Elasticsearch Resources Title plural
        /// </summary>
        [ResourceEntry("ElasticsearchResourcesTitlePlural",
            Value = "Elasticsearch module labels",
            Description = "The title plural of this class.",
            LastModified = "2014.07.02")]
        public string ElasticsearchResourcesTitlePlural
        {
            get
            {
                return this["ElasticsearchResourcesTitlePlural"];
            }
        }

        /// <summary>
        /// Contains localizable resources for Elasticsearch module.
        /// </summary>
        [ResourceEntry("ElasticsearchResourcesDescription",
            Value = "Contains localizable resources for Elasticsearch module.",
            Description = "The description of this class.",
            LastModified = "2014.07.02")]
        public string ElasticsearchResourcesDescription
        {
            get
            {
                return this["ElasticsearchResourcesDescription"];
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
        /// Title of the link for closing the dialog and going back to the Elasticsearch module
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

        #region ElasticsearchItems
        /// <summary>
        /// Messsage: PageTitle
        /// </summary>
        /// <value>Title for the ElasticsearchItem's page.</value>
        [ResourceEntry("ElasticsearchItemGroupPageTitle",
            Value = "ElasticsearchItem",
            Description = "The title of ElasticsearchItem's page.",
            LastModified = "2014.07.02")]
        public string ElasticsearchItemGroupPageTitle
        {
            get
            {
                return this["ElasticsearchItemGroupPageTitle"];
            }
        }

        /// <summary>
        /// Messsage: PageDescription
        /// </summary>
        /// <value>Description for the ElasticsearchItem's page.</value>
        [ResourceEntry("ElasticsearchItemGroupPageDescription",
            Value = "ElasticsearchItem",
            Description = "The description of ElasticsearchItem's page.",
            LastModified = "2014.07.02")]
        public string ElasticsearchItemGroupPageDescription
        {
            get
            {
                return this["ElasticsearchItemGroupPageDescription"];
            }
        }

        /// <summary>
        /// The URL name of ElasticsearchItem's page.
        /// </summary>
        [ResourceEntry("ElasticsearchItemGroupPageUrlName",
            Value = "Elasticsearch-ElasticsearchItem",
            Description = "The URL name of ElasticsearchItem's page.",
            LastModified = "2014.07.02")]
        public string ElasticsearchItemGroupPageUrlName
        {
            get
            {
                return this["ElasticsearchItemGroupPageUrlName"];
            }
        }

        /// <summary>
        /// Message displayed to user when no elasticSearchItems exist in the system
        /// </summary>
        /// <value>No elasticSearchItems have been created yet</value>
        [ResourceEntry("NoElasticsearchItemsCreatedMessage",
            Value = "No elasticSearchItems have been created yet",
            Description = "Message displayed to user when no elasticSearchItems exist in the system",
            LastModified = "2014.07.02")]
        public string NoElasticsearchItemsCreatedMessage
        {
            get
            {
                return this["NoElasticsearchItemsCreatedMessage"];
            }
        }

        /// <summary>
        /// Title of the button for creating a new elasticSearchItem
        /// </summary>
        /// <value>Create a elasticSearchItem</value>
        [ResourceEntry("CreateAElasticsearchItem",
            Value = "Create a elasticSearchItem",
            Description = "Title of the button for creating a new elasticSearchItem",
            LastModified = "2014.07.02")]
        public string CreateAElasticsearchItem
        {
            get
            {
                return this["CreateAElasticsearchItem"];
            }
        }

        /// <summary>
        /// Label for editing a new elasticSearchItem
        /// </summary>
        /// <value>Create a elasticSearchItem</value>
        [ResourceEntry("EditAElasticsearchItem",
            Value = "Edit a elasticSearchItem",
            Description = "Label for editing a new elasticSearchItem",
            LastModified = "2014.07.02")]
        public string EditAElasticsearchItem
        {
            get
            {
                return this["EditAElasticsearchItem"];
            }
        }

        /// <summary>
        /// ElasticsearchItem Title.
        /// </summary>
        /// <value>Title</value>
        [ResourceEntry("ElasticsearchItemTitleLabel",
            Value = "Title",
            Description = "ElasticsearchItem Title.",
            LastModified = "2014.07.02")]
        public string ElasticsearchItemTitleLabel
        {
            get
            {
                return this["ElasticsearchItemTitleLabel"];
            }
        }

        /// <summary>
        /// ElasticsearchItem Title description.
        /// </summary>
        /// <value>Enter the item's title (required)</value>
        [ResourceEntry("ElasticsearchItemTitleDescription",
            Value = "Enter the item's title (required)",
            Description = "ElasticsearchItem Title description.",
            LastModified = "2014.07.02")]
        public string ElasticsearchItemTitleDescription
        {
            get
            {
                return this["ElasticsearchItemTitleDescription"];
            }
        }

        /// <summary>
        /// Error message displayed if the user does not enter elasticSearchItem Title.
        /// </summary>
        [ResourceEntry("ElasticsearchItemTitleCannotBeEmpty",
            Value = "The Title of the elasticSearchItem cannot be empty.",
            Description = "Error message displayed if the user does not enter elasticSearchItem Title.",
            LastModified = "2014.07.02")]
        public string ElasticsearchItemTitleCannotBeEmpty
        {
            get
            {
                return this["ElasticsearchItemTitleCannotBeEmpty"];
            }
        }

        /// <summary>
        /// Error message displayed if the user enters too long Title.
        /// </summary>
        /// <value>Title value is too long. Maximum allowed is 255 characters.</value>
        [ResourceEntry("ElasticsearchItemTitleInvalidLength",
            Value = "Title value is too long. Maximum allowed is 255 characters.",
            Description = "Error message displayed if the user enters too long Title.",
            LastModified = "2014.07.02")]
        public string ElasticsearchItemTitleInvalidLength
        {
            get
            {
                return this["ElasticsearchItemTitleInvalidLength"];
            }
        }

        /// <summary>
        /// Message displayed to user when deleting a user elasticSearchItem.
        /// </summary>
        [ResourceEntry("DeleteElasticsearchItemConfirmationMessage",
            Value = "Are you sure you want to delete this elasticSearchItem?",
            Description = "Message displayed to user when deleting a user elasticSearchItem.",
            LastModified = "2014.07.02")]
        public string DeleteElasticsearchItemConfirmationMessage
        {
            get
            {
                return this["DeleteElasticsearchItemConfirmationMessage"];
            }
        }

        /// <summary>
        /// phrase: Create this elasticSearchItem
        /// </summary>
        [ResourceEntry("CreateThisElasticsearchItemButton",
            Value = "Create this elasticSearchItem",
            Description = "phrase: Create this elasticSearchItem",
            LastModified = "2014.07.02")]
        public string CreateThisElasticsearchItemButton
        {
            get
            {
                return this["CreateThisElasticsearchItemButton"];
            }
        }

        /// <summary>
        /// The URL name of ElasticsearchItem's page.
        /// </summary>
        /// <value>ElasticsearchItemMasterPageUrl</value>
        [ResourceEntry("ElasticsearchItemMasterPageUrl",
            Value = "ElasticsearchItemMasterPageUrl",
            Description = "The URL name of ElasticsearchItem's page.",
            LastModified = "2014.07.02")]
        public string ElasticsearchItemMasterPageUrl
        {
            get
            {
                return this["ElasticsearchItemMasterPageUrl"];
            }
        }
        #endregion
    }
}

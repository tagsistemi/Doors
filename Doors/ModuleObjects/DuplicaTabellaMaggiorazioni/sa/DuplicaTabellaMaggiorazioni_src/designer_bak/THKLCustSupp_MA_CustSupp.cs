using System.Threading.Channels;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using System.Numerics;
using System.Buffers.Binary;
using System.Buffers.Text;
using System.IO.Pipelines;
using System.Runtime.InteropServices;
using System.IO.MemoryMappedFiles;
using System.Threading;
using System.IO.Pipes;
using System.IO;
using System.Diagnostics.PerformanceData;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using System.Security;
using Microsoft.Win32.SafeHandles;
using System.Linq;
using System.Diagnostics.Eventing.Reader;
using System.Management.Instrumentation;
using System.Diagnostics.Eventing;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Buffers;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Microsoft.Extensions.Primitives;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Configuration.Memory;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks.Sources;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.SignalR.Protocol;
using Microsoft.AspNetCore.SignalR;
using Microsoft.AspNetCore.SignalR.Client;
using Microsoft.AspNetCore.Http.Features.Authentication;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.AspNetCore.Http.Connections.Client;
using Microsoft.AspNetCore.Connections.Features;
using Microsoft.AspNetCore.Connections;
using Microsoft.Xml.Serialization.GeneratedAssembly;
using DoorsAddoOnLibrary.Models;
using DoorsAddoOnLibrary.BillOfMaterialsComponents;
using DoorsAddoOnLibrary.LoginManager;
using DoorsAddoOnLibrary.TbServices;
using DoorsAddoOnLibrary;
using DevExpress.XtraTreeList.Printing;
using DevExpress.XtraTreeList.ViewInfo;
using DevExpress.XtraTreeList.Menu;
using DevExpress.XtraTreeList.Helpers;
using DevExpress.XtraTreeList.Handler;
using DevExpress.XtraTreeList.Painter;
using DevExpress.XtraTreeList.Data;
using DevExpress.XtraTreeList.StyleFormatConditions;
using DevExpress.XtraTreeList.Scrolling;
using DevExpress.XtraTreeList.Frames;
using DevExpress.XtraTreeList.Design;
using DevExpress.XtraTreeList.Localization;
using DevExpress.XtraTreeList.Internal;
using DevExpress.XtraTreeList.Columns;
using DevExpress.XtraTreeList.FilterEditor;
using DevExpress.XtraTreeList.Nodes.Operations;
using DevExpress.XtraTreeList.Native;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList.Dragging;
using DevExpress.XtraTreeList.Accessibility;
using DevExpress.XtraTreeList.Blending;
using DevExpress.XtraTreeList;
using DevExpress.XtraLayout.Tab;
using DevExpress.XtraLayout.Scrolling;
using DevExpress.XtraLayout.Registrator;
using DevExpress.XtraLayout.Localization;
using DevExpress.XtraLayout.Converter;
using DevExpress.XtraLayout.Printing;
using DevExpress.XtraLayout.Dragging;
using DevExpress.XtraLayout.Diagnostics;
using DevExpress.XtraDataLayout;
using DevExpress.XtraLayout.Helpers;
using DevExpress.XtraDashboardLayout;
using DevExpress.XtraLayout.Customization.Controls;
using DevExpress.XtraLayout.Utils;
using DevExpress.XtraLayout.Accessibility;
using DevExpress.XtraLayout.ViewInfo;
using DevExpress.XtraLayout.Painting;
using DevExpress.XtraLayout.HitInfo;
using DevExpress.XtraLayout.Customization;
using DevExpress.XtraLayout.Resizing;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Handlers;
using DevExpress.XtraLayout.Adapters;
using DevExpress.XtraGrid.Repository;
using DevExpress.XtraGrid.Tab;
using DevExpress.XtraGrid.Filter.Parser;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Filter;
using DevExpress.XtraGrid.Printing;
using DevExpress.XtraGrid.Editors;
using DevExpress.XtraGrid.Frames;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Layout.Printing;
using DevExpress.XtraGrid.Views.Layout.Drawing;
using DevExpress.XtraGrid.Views.Layout.Modes;
using DevExpress.XtraGrid.Views.Layout.Customization;
using DevExpress.XtraGrid.Views.Layout.Events;
using DevExpress.XtraGrid.Views.Layout.ViewInfo;
using DevExpress.XtraGrid.Views.Layout.Frames;
using DevExpress.XtraGrid.Views.Layout.Handler;
using DevExpress.XtraGrid.Views.Layout.Designer;
using DevExpress.XtraGrid.Views.Layout;
using DevExpress.XtraGrid.GroupSummaryEditor;
using DevExpress.XtraGrid.Localization;
using DevExpress.XtraGrid.Drawing;
using DevExpress.XtraGrid.Internal;
using DevExpress.XtraGrid.FilterEditor;
using DevExpress.XtraGrid.Export;
using DevExpress.XtraGrid.Views.Card.ViewInfo;
using DevExpress.XtraGrid.Views.Card.Drawing;
using DevExpress.XtraGrid.Views.Card.Handler;
using DevExpress.XtraGrid.Views.Card;
using DevExpress.XtraGrid.Design;
using DevExpress.XtraGrid.Blending;
using DevExpress.XtraGrid.Helpers;
using DevExpress.XtraGrid.Controls;
using DevExpress.XtraGrid.Views.Printing;
using DevExpress.XtraGrid.Scrolling;
using DevExpress.XtraGrid.Accessibility;
using DevExpress.XtraGrid.Views.BandedGrid.Customization;
using DevExpress.XtraGrid.Views.Grid.Customization;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Skins;
using DevExpress.XtraGrid.Views.BandedGrid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.BandedGrid.Drawing;
using DevExpress.XtraGrid.Views.Grid.Drawing;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.Handler;
using DevExpress.XtraGrid.Views.Grid.Handler;
using DevExpress.XtraGrid.Views.BandedGrid.Handler;
using DevExpress.XtraGrid.Dragging;
using DevExpress.XtraEditors.FeatureBrowser;
using DevExpress.XtraTab.Buttons;
using DevExpress.XtraTab.Registrator;
using DevExpress.XtraTab.Drawing;
using DevExpress.XtraTab.ViewInfo;
using DevExpress.Accessibility.Tab;
using DevExpress.XtraWaitForm;
using DevExpress.XtraSplashForm;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Internal;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraTab;
using DevExpress.XtraEditors.ColorPickEditControl;
using DevExpress.XtraEditors.Calendar;
using DevExpress.XtraEditors.NavigatorButtons;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Helpers;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors.Design;
using DevExpress.XtraEditors.Frames;
using DevExpress.XtraEditors.Customization;
using DevExpress.XtraEditors.ListControls;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.CodedUISupport;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraEditors.ButtonPanel;
using DevExpress.XtraEditors.Senders;
using DevExpress.XtraEditors.Persistent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraBars.Alerter;
using DevExpress.Utils.Frames;
using DevExpress.Utils.WXPaint;
using DevExpress.Utils.Mdi;
using DevExpress.Utils.Registrator;
using DevExpress.Utils.Native;
using DevExpress.Skins.Info;
using DevExpress.Skins.XtraForm;
using DevExpress.UserSkins;
using DevExpress.XtraReports.Serialization;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils.NonclientArea;
using DevExpress.Utils.Drawing.Helpers;
using DevExpress.Utils.Helpers;
using DevExpress.Utils.Paint;
using DevExpress.LookAndFeel.Design;
using DevExpress.LookAndFeel.Helpers;
using DevExpress.Utils.Win.Hook;
using DevExpress.Utils.ViewInfo;
using DevExpress.Utils.ToolTip.ViewInfo;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors.ScrollHelpers;
using DevExpress.Utils.Win;
using DevExpress.Utils.DragDrop;
using DevExpress.Skins;
using DevExpress.Utils.Gesture;
using DevExpress.Utils.Compress;
using DevExpress.Utils.CodedUISupport;
using DevExpress.Utils.Drawing;
using DevExpress.Utils.Drawing.Animation;
using DevExpress.Accessibility;
using DevExpress.LookAndFeel;
using DevExpress.XtraEditors.Drawing;
using DevExpress.Printing.ServiceModel.DataContracts;
using DevExpress.Xpf.Printing.ServiceModel.DataContracts;
using DevExpress.XtraReports.ServiceModel.DataContracts;
using DevExpress.XtraPrinting.Drawing;
using DevExpress.XtraPrinting.Preview;
using DevExpress.Printing;
using DevExpress.XtraReports;
using DevExpress.XtraPrinting.InternalAccess;
using DevExpress.XtraPrinting.Export.Pdf.Compression;
using System.Collections;
using DevExpress.XtraPrinting.Native.LayoutAdjustment;
using DevExpress.XtraPrinting.Native.TextRotation;
using DevExpress.XtraPrinting.Native.Navigation;
using DevExpress.XtraPrinting.Native.Lines;
using DevExpress.XtraPrinting.HtmlExport;
using DevExpress.XtraPrinting.HtmlExport.Native;
using DevExpress.XtraPrinting.Export.XLS;
using DevExpress.XtraPrinting.Export.Text;
using DevExpress.XtraPrinting.Export.Rtf;
using DevExpress.XtraPrinting.Export.Imaging;
using DevExpress.XtraPrinting.Native.ExportOtions;
using DevExpress.XtraPrinting.Native.ExportOptionsControllers;
using DevExpress.XtraPrinting.Shape;
using DevExpress.XtraPrinting.Shape.Native;
using DevExpress.XtraPrinting.NativeBricks;
using DevExpress.XtraPrinting.Export.Pdf;
using DevExpress.XtraPrinting.Export;
using DevExpress.Printing.Core.Native;
using DevExpress.Printing.Core;
using DevExpress.XtraPrintingLinks;
using DevExpress.Printing.Core.HtmlExport;
using DevExpress.XtraPrinting.Export.Web;
using DevExpress.XtraPrinting.HtmlExport.Controls;
using DevExpress.XtraPrinting.BarCode.Native;
using DevExpress.XtraPrinting.BarCode;
using DevExpress.XtraPrinting.BrickExporters;
using DevExpress.Data.XtraReports.Wizard.Views;
using DevExpress.Data.XtraReports.Wizard.Presenters;
using DevExpress.Utils.Implementation;
using DevExpress.Data.Summary;
using DevExpress.Data.Async.Helpers;
using DevExpress.Schedule.Serializing;
using DevExpress.Schedule;
using DevExpress.Utils.Text.Internal;
using DevExpress.Data.Async;
using DevExpress.Data.Printing.Native;
using DevExpress.Utils.Zip;
using DevExpress.XtraPrinting.Localization;
using DevExpress.XtraPrinting.DataNodes;
using DevExpress.Data.ChartDataSources;
using DevExpress.Charts.Native;
using DevExpress.Xpo.Logger.Transport;
using DevExpress.Xpo.Logger;
using DevExpress.Utils.Text;
using DevExpress.XtraEditors.Filtering;
using DevExpress.XtraEditors;
using DevExpress.Data.ExpressionEditor;
using DevExpress.XtraExport;
using DevExpress.Data.Linq.Helpers;
using DevExpress.Data.Linq;
using DevExpress.Utils.Internal;
using DevExpress.Xpo.Providers;
using DevExpress.Data.Db;
using DevExpress.Data.Design;
using DevExpress.Xpo.XtraData;
using DevExpress.Data.Utils.ServiceModel.Native;
using DevExpress.CodeParser;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraPrinting;
using DevExpress.Internal;
using DevExpress.XtraPrinting.Design;
using DevExpress.Utils.Serializing.Helpers;
using DevExpress.Utils.Editors;
using DevExpress.Utils.Localization.Internal;
using DevExpress.Utils.Localization;
using DevExpress.Data.Utils;
using DevExpress.Utils.Serializing;
using DevExpress.WebUtils;
using DevExpress.Utils.Controls;
using DevExpress.Data.IO;
using DevExpress.XtraSpellChecker.Native;
using DevExpress.XtraSpellChecker.Parser;
using DevExpress.XtraSpellChecker;
using DevExpress.Services.Implementation;
using DevExpress.Services;
using DevExpress.XtraRichEdit.Export.Rtf;
using DevExpress.Data.Mask;
using DevExpress.Utils.KeyboardHandler;
using DevExpress.Utils.Design;
using DevExpress.Data.XtraReports.Wizard.Native;
using DevExpress.Data.XtraReports.Wizard;
using DevExpress.Data.XtraReports.ServiceModel.DataContracts;
using DevExpress.Data.XtraReports.ServiceModel;
using DevExpress.XtraReports.Parameters;
using DevExpress.Data.XtraReports.Native;
using DevExpress.Data.XtraReports.Labels;
using DevExpress.Data.XtraReports.DataProviders;
using DevExpress.XtraReports.Design.Commands;
using DevExpress.XtraReports.UserDesigner;
using DevExpress.XtraReports.Native.Parameters;
using DevExpress.XtraReports.UI;
using DevExpress.Data.WizardFramework;
using DevExpress.Utils.About;
using DevExpress.Data.Utils.ServiceModel;
using DevExpress.Utils.IoC;
using DevExpress.Xpf.Printing;
using DevExpress.XtraPrinting.Native;
using DevExpress.Utils.OAuth.Provider;
using DevExpress.Utils.OAuth;
using DevExpress.Utils.Gac;
using DevExpress.XtraGrid;
using DevExpress.Data.Filtering.Exceptions;
using DevExpress.Xpo;
using DevExpress.Utils.Extensions.Helpers;
using DevExpress.Data.Details;
using DevExpress.Xpo.Exceptions;
using DevExpress.Xpo.DB.Exceptions;
using DevExpress.Xpo.Helpers;
using DevExpress.Xpo.DB;
using DevExpress.Xpo.DB.Helpers;
using DevExpress.Data.Storage;
using DevExpress.Data.Access;
using DevExpress.Utils.Menu;
using DevExpress.Utils.Commands;
using DevExpress.Data.Filtering;
using DevExpress.Data.Helpers;
using DevExpress.Data.Selection;
using DevExpress.XtraReports.Native;
using DevExpress.XtraReports.Native.Data;
using DevExpress.Data.Browsing.Design;
using DevExpress.XtraReports.Design;
using DevExpress.Data;
using DevExpress.Services.Internal;
using DevExpress.Data.Browsing;
using DevExpress.Data.Filtering.Helpers;
using DevExpress.Data.Native;
using DevExpress.Utils;
using BusinessObjects.Doors.Doors.DynamicDocuments.Maggiorazioni;
using Microarea.Library.WCFGeneratedFunctions;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.OleDb;
using Microarea.EasyBuilder;
using Microarea.EasyBuilder.MVC;
using Microarea.TaskBuilderNet.UI.WinControls;
using Microarea.TaskBuilderNet.Interfaces.View;
using Microarea.TaskBuilderNet.Interfaces;
using Microarea.TaskBuilderNet.Core.CoreTypes;
using Microarea.TaskBuilderNet.Core.EasyBuilder;
using Microarea.TaskBuilderNet.Core.Generic;
using Microarea.Framework.TBApplicationWrapper;
using Microarea.TaskBuilderNet.Interfaces.Model;
using System.ComponentModel;
using System.Windows.Forms;
using System.Xml;
using System.Drawing;
using System.Data;
using System;
namespace Customization.Doors.Doors.DynamicDocuments.DuplicaTabellaMaggiorazioni.DuplicaTabellaMaggiorazioni
{
	public class THKLCustSupp_MA_CustSupp : Microarea.Framework.TBApplicationWrapper.MSqlRecord
	{
		public THKLCustSupp_MA_CustSupp(System.IntPtr wrappedObject) : base(wrappedObject)
		{
		}

		public MDataEnum fld_CustSuppType;

		public MDataStr fld_CustSupp;

		public MDataBool fld_Draft;

		public MDataStr fld_CompanyName;

		public MDataStr fld_ISOCountryCode;

		public MDataStr fld_TaxIdNumber;

		public MDataStr fld_FiscalCode;

		public MDataEnum fld_CustSuppKind;

		public MDataStr fld_Account;

		public MDataStr fld_Address;

		public MDataStr fld_ZIPCode;

		public MDataStr fld_City;

		public MDataStr fld_County;

		public MDataStr fld_Country;

		public MDataStr fld_Telephone1;

		public MDataStr fld_Telephone2;

		public MDataStr fld_Telex;

		public MDataStr fld_Fax;

		public MDataStr fld_Internet;

		public MDataStr fld_EMail;

		public MDataStr fld_SIACode;

		public MDataStr fld_ContactPerson;

		public MDataStr fld_TitleCode;

		public MDataBool fld_NaturalPerson;

		public MDataStr fld_Language;

		public MDataStr fld_PriceList;

		public MDataStr fld_CustSuppBank;

		public MDataStr fld_Payment;

		public MDataStr fld_CACheck;

		public MDataStr fld_IBAN;

		public MDataBool fld_IBANIsManual;

		public MDataStr fld_CA;

		public MDataStr fld_CIN;

		public MDataStr fld_Currency;

		public MDataStr fld_SendDocumentsTo;

		public MDataStr fld_PaymentAddress;

		public MDataStr fld_ShipToAddress;

		public MDataBool fld_Disabled;

		public MDataStr fld_Notes;

		public MDataStr fld_WorkingTime;

		public MDataStr fld_CompanyBank;

		public MDataPerc fld_Discount1;

		public MDataPerc fld_Discount2;

		public MDataStr fld_DiscountFormula;

		public MDataStr fld_ExternalCode;

		public MDataStr fld_CompanyCA;

		public MDataEnum fld_Presentation;

		public MDataStr fld_CustomerCompanyCA;

		public MDataStr fld_DDCustSupp;

		public MDataBool fld_PrivacyStatement;

		public MDataStr fld_LinkedCustSupp;

		public MDataEnum fld_DocumentSendingType;

		public MDataBool fld_IsDummy;

		public MDataBool fld_InTaxLists;

		public MDataStr fld_ChambOfCommRegistrNo;

		public MDataStr fld_WorkingPosition;

		public MDataStr fld_TaxOffice;

		public MDataStr fld_Storage;

		public MDataStr fld_CostCenter;

		public MDataStr fld_Job;

		public MDataDate fld_InsertionDate;

		public MDataDate fld_PrivacyStatementPrintDate;

		public MDataStr fld_Region;

		public MDataEnum fld_MailSendingType;

		public MDataStr fld_OldCustSupp;

		public MDataStr fld_CompanyRegistrNo;

		public MDataStr fld_FactoringCA;

		public MDataBool fld_InCurrency;

		public MDataBool fld_NoBlackList;

		public MDataStr fld_BlackListCustSupp;

		public MDataStr fld_SkypeID;

		public MDataStr fld_CBICode;

		public MDataStr fld_InvoiceAccTpl;

		public MDataStr fld_CreditNoteAccTpl;

		public MDataStr fld_Latitude;

		public MDataStr fld_Longitude;

		public MDataBool fld_IsCustoms;

		public MDataStr fld_CertifiedEMail;

		public MDataBool fld_NoTaxComm;

		public MDataBool fld_NoSendPostaLite;

		public MDataStr fld_GenRegNo;

		public MDataStr fld_GenRegEntity;

		public MDataStr fld_FedStateReg;

		public MDataEnum fld_TaxpayerType;

		public MDataStr fld_MunicipalityReg;

		public MDataStr fld_SUFRAMA;

		public MDataStr fld_Address2;

		public MDataStr fld_StreetNo;

		public MDataStr fld_District;

		public MDataStr fld_FederalState;

		public MDataStr fld_PaymentPeriShablesWithin60;

		public MDataStr fld_PaymentPeriShablesOver60;

		public MDataStr fld_FiscalCtg;

		public MDataStr fld_ActivityCode;

		public MDataStr fld_FantasyName;

		public MDataStr fld_PymtAccount;

		public MDataBool fld_UsedForSummaryDocuments;

		public MDataStr fld_LeasingLetter;

		public MDataStr fld_ChambOfCommCounty;

		public MDataBool fld_SplitTax;

		public MDataStr fld_FiscalName;

		public MDataEnum fld_TaxIdType;

		public MDataBool fld_PrivacyAgreed;

		public MDataBool fld_MarketingAgreed;

		public MDataStr fld_SplitTaxIBAN;

		public MDataStr fld_GLN;

		public MDataStr fld_GLNDataExchange;

		public MDataStr fld_CompNameComplete;

		public MDataStr fld_CompNameCompleteWithTaxNumber;

		public MDataStr fld_CadastralCode;

		public MDataStr fld_IPACode;

		public MDataStr fld_EORICode;

		public MDataBool fld_ImmediateLikeAccompanying;

		public MDataStr fld_AdministrationReference;

		public MDataBool fld_ElectronicInvoicing;

		public MDataBool fld_SendByCertifiedEmail;

		public MDataStr fld_PermanentBranchCode;

		public MDataStr fld_FDISOCountryCode;

		public MDataStr fld_FDFiscalCode;

		public MDataBool fld_FDNaturalPerson;

		public MDataStr fld_FDCompanyName;

		public MDataStr fld_FDName;

		public MDataStr fld_FDLastName;

		public MDataEnum fld_AswStandard;

		public MDataEnum fld_RegisterReceivedEI;

		public MDataStr fld_EICertifiedEMail;

		public MDataStr fld_EITypeCodeItemCustomer;

		public MDataStr fld_EITypeCodeItemBarcode;

		public MDataStr fld_EITypeCodeItem;

		public MDataEnum fld_EIUnitValue;

		public MDataEnum fld_RefDocReceivedEI;

		public MDataStr fld_FiscalRegime;

		public MDataStr fld_FDFiscalCodeID;

		public MDataStr fld_FDEORICode;

		public MDataStr fld_FDTitleCode;

		public MDataBool fld_NSOOrders;

		public MDataDate fld_TBCreated;

		public MDataDate fld_TBModified;

		public MDataLng fld_TBCreatedID;

		public MDataLng fld_TBModifiedID;

		public MDataGuid fld_TBGuid;

		public override void CreateComponents()
		{
			fld_CustSuppType = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("CustSuppType"));
			this.Add(fld_CustSuppType, false);
			fld_CustSupp = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CustSupp"));
			this.Add(fld_CustSupp, false);
			fld_Draft = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("Draft"));
			this.Add(fld_Draft, false);
			fld_CompanyName = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CompanyName"));
			this.Add(fld_CompanyName, false);
			fld_ISOCountryCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("ISOCountryCode"));
			this.Add(fld_ISOCountryCode, false);
			fld_TaxIdNumber = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("TaxIdNumber"));
			this.Add(fld_TaxIdNumber, false);
			fld_FiscalCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("FiscalCode"));
			this.Add(fld_FiscalCode, false);
			fld_CustSuppKind = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("CustSuppKind"));
			this.Add(fld_CustSuppKind, false);
			fld_Account = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Account"));
			this.Add(fld_Account, false);
			fld_Address = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Address"));
			this.Add(fld_Address, false);
			fld_ZIPCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("ZIPCode"));
			this.Add(fld_ZIPCode, false);
			fld_City = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("City"));
			this.Add(fld_City, false);
			fld_County = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("County"));
			this.Add(fld_County, false);
			fld_Country = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Country"));
			this.Add(fld_Country, false);
			fld_Telephone1 = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Telephone1"));
			this.Add(fld_Telephone1, false);
			fld_Telephone2 = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Telephone2"));
			this.Add(fld_Telephone2, false);
			fld_Telex = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Telex"));
			this.Add(fld_Telex, false);
			fld_Fax = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Fax"));
			this.Add(fld_Fax, false);
			fld_Internet = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Internet"));
			this.Add(fld_Internet, false);
			fld_EMail = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("EMail"));
			this.Add(fld_EMail, false);
			fld_SIACode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("SIACode"));
			this.Add(fld_SIACode, false);
			fld_ContactPerson = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("ContactPerson"));
			this.Add(fld_ContactPerson, false);
			fld_TitleCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("TitleCode"));
			this.Add(fld_TitleCode, false);
			fld_NaturalPerson = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("NaturalPerson"));
			this.Add(fld_NaturalPerson, false);
			fld_Language = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Language"));
			this.Add(fld_Language, false);
			fld_PriceList = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("PriceList"));
			this.Add(fld_PriceList, false);
			fld_CustSuppBank = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CustSuppBank"));
			this.Add(fld_CustSuppBank, false);
			fld_Payment = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Payment"));
			this.Add(fld_Payment, false);
			fld_CACheck = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CACheck"));
			this.Add(fld_CACheck, false);
			fld_IBAN = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("IBAN"));
			this.Add(fld_IBAN, false);
			fld_IBANIsManual = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("IBANIsManual"));
			this.Add(fld_IBANIsManual, false);
			fld_CA = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CA"));
			this.Add(fld_CA, false);
			fld_CIN = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CIN"));
			this.Add(fld_CIN, false);
			fld_Currency = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Currency"));
			this.Add(fld_Currency, false);
			fld_SendDocumentsTo = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("SendDocumentsTo"));
			this.Add(fld_SendDocumentsTo, false);
			fld_PaymentAddress = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("PaymentAddress"));
			this.Add(fld_PaymentAddress, false);
			fld_ShipToAddress = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("ShipToAddress"));
			this.Add(fld_ShipToAddress, false);
			fld_Disabled = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("Disabled"));
			this.Add(fld_Disabled, false);
			fld_Notes = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Notes"));
			this.Add(fld_Notes, false);
			fld_WorkingTime = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("WorkingTime"));
			this.Add(fld_WorkingTime, false);
			fld_CompanyBank = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CompanyBank"));
			this.Add(fld_CompanyBank, false);
			fld_Discount1 = new Microarea.Framework.TBApplicationWrapper.MDataPerc(this.GetFieldPtr("Discount1"));
			this.Add(fld_Discount1, false);
			fld_Discount2 = new Microarea.Framework.TBApplicationWrapper.MDataPerc(this.GetFieldPtr("Discount2"));
			this.Add(fld_Discount2, false);
			fld_DiscountFormula = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("DiscountFormula"));
			this.Add(fld_DiscountFormula, false);
			fld_ExternalCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("ExternalCode"));
			this.Add(fld_ExternalCode, false);
			fld_CompanyCA = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CompanyCA"));
			this.Add(fld_CompanyCA, false);
			fld_Presentation = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("Presentation"));
			this.Add(fld_Presentation, false);
			fld_CustomerCompanyCA = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CustomerCompanyCA"));
			this.Add(fld_CustomerCompanyCA, false);
			fld_DDCustSupp = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("DDCustSupp"));
			this.Add(fld_DDCustSupp, false);
			fld_PrivacyStatement = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("PrivacyStatement"));
			this.Add(fld_PrivacyStatement, false);
			fld_LinkedCustSupp = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("LinkedCustSupp"));
			this.Add(fld_LinkedCustSupp, false);
			fld_DocumentSendingType = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("DocumentSendingType"));
			this.Add(fld_DocumentSendingType, false);
			fld_IsDummy = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("IsDummy"));
			this.Add(fld_IsDummy, false);
			fld_InTaxLists = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("InTaxLists"));
			this.Add(fld_InTaxLists, false);
			fld_ChambOfCommRegistrNo = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("ChambOfCommRegistrNo"));
			this.Add(fld_ChambOfCommRegistrNo, false);
			fld_WorkingPosition = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("WorkingPosition"));
			this.Add(fld_WorkingPosition, false);
			fld_TaxOffice = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("TaxOffice"));
			this.Add(fld_TaxOffice, false);
			fld_Storage = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Storage"));
			this.Add(fld_Storage, false);
			fld_CostCenter = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CostCenter"));
			this.Add(fld_CostCenter, false);
			fld_Job = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Job"));
			this.Add(fld_Job, false);
			fld_InsertionDate = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("InsertionDate"));
			this.Add(fld_InsertionDate, false);
			fld_PrivacyStatementPrintDate = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("PrivacyStatementPrintDate"));
			this.Add(fld_PrivacyStatementPrintDate, false);
			fld_Region = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Region"));
			this.Add(fld_Region, false);
			fld_MailSendingType = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("MailSendingType"));
			this.Add(fld_MailSendingType, false);
			fld_OldCustSupp = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("OldCustSupp"));
			this.Add(fld_OldCustSupp, false);
			fld_CompanyRegistrNo = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CompanyRegistrNo"));
			this.Add(fld_CompanyRegistrNo, false);
			fld_FactoringCA = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("FactoringCA"));
			this.Add(fld_FactoringCA, false);
			fld_InCurrency = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("InCurrency"));
			this.Add(fld_InCurrency, false);
			fld_NoBlackList = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("NoBlackList"));
			this.Add(fld_NoBlackList, false);
			fld_BlackListCustSupp = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("BlackListCustSupp"));
			this.Add(fld_BlackListCustSupp, false);
			fld_SkypeID = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("SkypeID"));
			this.Add(fld_SkypeID, false);
			fld_CBICode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CBICode"));
			this.Add(fld_CBICode, false);
			fld_InvoiceAccTpl = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("InvoiceAccTpl"));
			this.Add(fld_InvoiceAccTpl, false);
			fld_CreditNoteAccTpl = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CreditNoteAccTpl"));
			this.Add(fld_CreditNoteAccTpl, false);
			fld_Latitude = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Latitude"));
			this.Add(fld_Latitude, false);
			fld_Longitude = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Longitude"));
			this.Add(fld_Longitude, false);
			fld_IsCustoms = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("IsCustoms"));
			this.Add(fld_IsCustoms, false);
			fld_CertifiedEMail = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CertifiedEMail"));
			this.Add(fld_CertifiedEMail, false);
			fld_NoTaxComm = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("NoTaxComm"));
			this.Add(fld_NoTaxComm, false);
			fld_NoSendPostaLite = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("NoSendPostaLite"));
			this.Add(fld_NoSendPostaLite, false);
			fld_GenRegNo = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("GenRegNo"));
			this.Add(fld_GenRegNo, false);
			fld_GenRegEntity = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("GenRegEntity"));
			this.Add(fld_GenRegEntity, false);
			fld_FedStateReg = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("FedStateReg"));
			this.Add(fld_FedStateReg, false);
			fld_TaxpayerType = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("TaxpayerType"));
			this.Add(fld_TaxpayerType, false);
			fld_MunicipalityReg = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MunicipalityReg"));
			this.Add(fld_MunicipalityReg, false);
			fld_SUFRAMA = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("SUFRAMA"));
			this.Add(fld_SUFRAMA, false);
			fld_Address2 = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Address2"));
			this.Add(fld_Address2, false);
			fld_StreetNo = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("StreetNo"));
			this.Add(fld_StreetNo, false);
			fld_District = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("District"));
			this.Add(fld_District, false);
			fld_FederalState = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("FederalState"));
			this.Add(fld_FederalState, false);
			fld_PaymentPeriShablesWithin60 = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("PaymentPeriShablesWithin60"));
			this.Add(fld_PaymentPeriShablesWithin60, false);
			fld_PaymentPeriShablesOver60 = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("PaymentPeriShablesOver60"));
			this.Add(fld_PaymentPeriShablesOver60, false);
			fld_FiscalCtg = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("FiscalCtg"));
			this.Add(fld_FiscalCtg, false);
			fld_ActivityCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("ActivityCode"));
			this.Add(fld_ActivityCode, false);
			fld_FantasyName = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("FantasyName"));
			this.Add(fld_FantasyName, false);
			fld_PymtAccount = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("PymtAccount"));
			this.Add(fld_PymtAccount, false);
			fld_UsedForSummaryDocuments = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("UsedForSummaryDocuments"));
			this.Add(fld_UsedForSummaryDocuments, false);
			fld_LeasingLetter = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("LeasingLetter"));
			this.Add(fld_LeasingLetter, false);
			fld_ChambOfCommCounty = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("ChambOfCommCounty"));
			this.Add(fld_ChambOfCommCounty, false);
			fld_SplitTax = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("SplitTax"));
			this.Add(fld_SplitTax, false);
			fld_FiscalName = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("FiscalName"));
			this.Add(fld_FiscalName, false);
			fld_TaxIdType = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("TaxIdType"));
			this.Add(fld_TaxIdType, false);
			fld_PrivacyAgreed = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("PrivacyAgreed"));
			this.Add(fld_PrivacyAgreed, false);
			fld_MarketingAgreed = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("MarketingAgreed"));
			this.Add(fld_MarketingAgreed, false);
			fld_SplitTaxIBAN = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("SplitTaxIBAN"));
			this.Add(fld_SplitTaxIBAN, false);
			fld_GLN = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("GLN"));
			this.Add(fld_GLN, false);
			fld_GLNDataExchange = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("GLNDataExchange"));
			this.Add(fld_GLNDataExchange, false);
			fld_CompNameComplete = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CompNameComplete"));
			this.Add(fld_CompNameComplete, false);
			fld_CompNameCompleteWithTaxNumber = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CompNameCompleteWithTaxNumber"));
			this.Add(fld_CompNameCompleteWithTaxNumber, false);
			fld_CadastralCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CadastralCode"));
			this.Add(fld_CadastralCode, false);
			fld_IPACode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("IPACode"));
			this.Add(fld_IPACode, false);
			fld_EORICode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("EORICode"));
			this.Add(fld_EORICode, false);
			fld_ImmediateLikeAccompanying = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("ImmediateLikeAccompanying"));
			this.Add(fld_ImmediateLikeAccompanying, false);
			fld_AdministrationReference = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("AdministrationReference"));
			this.Add(fld_AdministrationReference, false);
			fld_ElectronicInvoicing = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("ElectronicInvoicing"));
			this.Add(fld_ElectronicInvoicing, false);
			fld_SendByCertifiedEmail = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("SendByCertifiedEmail"));
			this.Add(fld_SendByCertifiedEmail, false);
			fld_PermanentBranchCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("PermanentBranchCode"));
			this.Add(fld_PermanentBranchCode, false);
			fld_FDISOCountryCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("FDISOCountryCode"));
			this.Add(fld_FDISOCountryCode, false);
			fld_FDFiscalCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("FDFiscalCode"));
			this.Add(fld_FDFiscalCode, false);
			fld_FDNaturalPerson = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("FDNaturalPerson"));
			this.Add(fld_FDNaturalPerson, false);
			fld_FDCompanyName = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("FDCompanyName"));
			this.Add(fld_FDCompanyName, false);
			fld_FDName = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("FDName"));
			this.Add(fld_FDName, false);
			fld_FDLastName = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("FDLastName"));
			this.Add(fld_FDLastName, false);
			fld_AswStandard = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("AswStandard"));
			this.Add(fld_AswStandard, false);
			fld_RegisterReceivedEI = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("RegisterReceivedEI"));
			this.Add(fld_RegisterReceivedEI, false);
			fld_EICertifiedEMail = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("EICertifiedEMail"));
			this.Add(fld_EICertifiedEMail, false);
			fld_EITypeCodeItemCustomer = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("EITypeCodeItemCustomer"));
			this.Add(fld_EITypeCodeItemCustomer, false);
			fld_EITypeCodeItemBarcode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("EITypeCodeItemBarcode"));
			this.Add(fld_EITypeCodeItemBarcode, false);
			fld_EITypeCodeItem = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("EITypeCodeItem"));
			this.Add(fld_EITypeCodeItem, false);
			fld_EIUnitValue = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("EIUnitValue"));
			this.Add(fld_EIUnitValue, false);
			fld_RefDocReceivedEI = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("RefDocReceivedEI"));
			this.Add(fld_RefDocReceivedEI, false);
			fld_FiscalRegime = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("FiscalRegime"));
			this.Add(fld_FiscalRegime, false);
			fld_FDFiscalCodeID = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("FDFiscalCodeID"));
			this.Add(fld_FDFiscalCodeID, false);
			fld_FDEORICode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("FDEORICode"));
			this.Add(fld_FDEORICode, false);
			fld_FDTitleCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("FDTitleCode"));
			this.Add(fld_FDTitleCode, false);
			fld_NSOOrders = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("NSOOrders"));
			this.Add(fld_NSOOrders, false);
			fld_TBCreated = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("TBCreated"));
			this.Add(fld_TBCreated, false);
			fld_TBModified = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("TBModified"));
			this.Add(fld_TBModified, false);
			fld_TBCreatedID = new Microarea.Framework.TBApplicationWrapper.MDataLng(this.GetFieldPtr("TBCreatedID"));
			this.Add(fld_TBCreatedID, false);
			fld_TBModifiedID = new Microarea.Framework.TBApplicationWrapper.MDataLng(this.GetFieldPtr("TBModifiedID"));
			this.Add(fld_TBModifiedID, false);
			fld_TBGuid = new Microarea.Framework.TBApplicationWrapper.MDataGuid(this.GetFieldPtr("TBGuid"));
			this.Add(fld_TBGuid, false);
		}

		public override void ApplyResources()
		{
			Microarea.EasyBuilder.CustomizationComponentResourceManager resources = Strings.ResourceManager;
		}

		public override void ClearComponents()
		{
			base.ClearComponents();
			fld_CustSuppType = null;
			fld_CustSupp = null;
			fld_Draft = null;
			fld_CompanyName = null;
			fld_ISOCountryCode = null;
			fld_TaxIdNumber = null;
			fld_FiscalCode = null;
			fld_CustSuppKind = null;
			fld_Account = null;
			fld_Address = null;
			fld_ZIPCode = null;
			fld_City = null;
			fld_County = null;
			fld_Country = null;
			fld_Telephone1 = null;
			fld_Telephone2 = null;
			fld_Telex = null;
			fld_Fax = null;
			fld_Internet = null;
			fld_EMail = null;
			fld_SIACode = null;
			fld_ContactPerson = null;
			fld_TitleCode = null;
			fld_NaturalPerson = null;
			fld_Language = null;
			fld_PriceList = null;
			fld_CustSuppBank = null;
			fld_Payment = null;
			fld_CACheck = null;
			fld_IBAN = null;
			fld_IBANIsManual = null;
			fld_CA = null;
			fld_CIN = null;
			fld_Currency = null;
			fld_SendDocumentsTo = null;
			fld_PaymentAddress = null;
			fld_ShipToAddress = null;
			fld_Disabled = null;
			fld_Notes = null;
			fld_WorkingTime = null;
			fld_CompanyBank = null;
			fld_Discount1 = null;
			fld_Discount2 = null;
			fld_DiscountFormula = null;
			fld_ExternalCode = null;
			fld_CompanyCA = null;
			fld_Presentation = null;
			fld_CustomerCompanyCA = null;
			fld_DDCustSupp = null;
			fld_PrivacyStatement = null;
			fld_LinkedCustSupp = null;
			fld_DocumentSendingType = null;
			fld_IsDummy = null;
			fld_InTaxLists = null;
			fld_ChambOfCommRegistrNo = null;
			fld_WorkingPosition = null;
			fld_TaxOffice = null;
			fld_Storage = null;
			fld_CostCenter = null;
			fld_Job = null;
			fld_InsertionDate = null;
			fld_PrivacyStatementPrintDate = null;
			fld_Region = null;
			fld_MailSendingType = null;
			fld_OldCustSupp = null;
			fld_CompanyRegistrNo = null;
			fld_FactoringCA = null;
			fld_InCurrency = null;
			fld_NoBlackList = null;
			fld_BlackListCustSupp = null;
			fld_SkypeID = null;
			fld_CBICode = null;
			fld_InvoiceAccTpl = null;
			fld_CreditNoteAccTpl = null;
			fld_Latitude = null;
			fld_Longitude = null;
			fld_IsCustoms = null;
			fld_CertifiedEMail = null;
			fld_NoTaxComm = null;
			fld_NoSendPostaLite = null;
			fld_GenRegNo = null;
			fld_GenRegEntity = null;
			fld_FedStateReg = null;
			fld_TaxpayerType = null;
			fld_MunicipalityReg = null;
			fld_SUFRAMA = null;
			fld_Address2 = null;
			fld_StreetNo = null;
			fld_District = null;
			fld_FederalState = null;
			fld_PaymentPeriShablesWithin60 = null;
			fld_PaymentPeriShablesOver60 = null;
			fld_FiscalCtg = null;
			fld_ActivityCode = null;
			fld_FantasyName = null;
			fld_PymtAccount = null;
			fld_UsedForSummaryDocuments = null;
			fld_LeasingLetter = null;
			fld_ChambOfCommCounty = null;
			fld_SplitTax = null;
			fld_FiscalName = null;
			fld_TaxIdType = null;
			fld_PrivacyAgreed = null;
			fld_MarketingAgreed = null;
			fld_SplitTaxIBAN = null;
			fld_GLN = null;
			fld_GLNDataExchange = null;
			fld_CompNameComplete = null;
			fld_CompNameCompleteWithTaxNumber = null;
			fld_CadastralCode = null;
			fld_IPACode = null;
			fld_EORICode = null;
			fld_ImmediateLikeAccompanying = null;
			fld_AdministrationReference = null;
			fld_ElectronicInvoicing = null;
			fld_SendByCertifiedEmail = null;
			fld_PermanentBranchCode = null;
			fld_FDISOCountryCode = null;
			fld_FDFiscalCode = null;
			fld_FDNaturalPerson = null;
			fld_FDCompanyName = null;
			fld_FDName = null;
			fld_FDLastName = null;
			fld_AswStandard = null;
			fld_RegisterReceivedEI = null;
			fld_EICertifiedEMail = null;
			fld_EITypeCodeItemCustomer = null;
			fld_EITypeCodeItemBarcode = null;
			fld_EITypeCodeItem = null;
			fld_EIUnitValue = null;
			fld_RefDocReceivedEI = null;
			fld_FiscalRegime = null;
			fld_FDFiscalCodeID = null;
			fld_FDEORICode = null;
			fld_FDTitleCode = null;
			fld_NSOOrders = null;
			fld_TBCreated = null;
			fld_TBModified = null;
			fld_TBCreatedID = null;
			fld_TBModifiedID = null;
			fld_TBGuid = null;
		}
	}
}

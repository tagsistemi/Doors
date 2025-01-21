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

namespace BusinessObjects.Doors.Doors.DynamicDocuments.Maggiorazioni
{
	public static class Strings
	{
		public static Microarea.EasyBuilder.CustomizationComponentResourceManager ResourceManager = new Microarea.EasyBuilder.CustomizationComponentResourceManager(typeof(Strings));
	}
	[Microarea.TaskBuilderNet.Core.EasyBuilder.DocumentNamespaceAttribute("Document.Doors.Doors.DynamicDocuments.Maggiorazioni")]
	public class MDMaggiorazioni : BusinessObject
	{
		public MDMaggiorazioni(System.IntPtr wrappedObject) : base(wrappedObject)
		{
			DocumentController.controller = new Microarea.EasyBuilder.MVC.DocumentController(this);
			this.CallCreateComponents();
		}

		public static MDMaggiorazioni Create()
		{
			return MDMaggiorazioni.Create<MDMaggiorazioni>("Document.Doors.Doors.DynamicDocuments.Maggiorazioni");
		}

		public static MDMaggiorazioni Create(Microarea.Framework.TBApplicationWrapper.DocumentContext context)
		{
			return MDMaggiorazioni.Create<MDMaggiorazioni>("Document.Doors.Doors.DynamicDocuments.Maggiorazioni", context);
		}

		public static MDMaggiorazioni CreateUnattended(Microarea.Framework.TBApplicationWrapper.DocumentContext context)
		{
			return MDMaggiorazioni.CreateUnattended<MDMaggiorazioni>("Document.Doors.Doors.DynamicDocuments.Maggiorazioni", context);
		}

		public static MDMaggiorazioni CreateHidden(Microarea.Framework.TBApplicationWrapper.DocumentContext context)
		{
			return MDMaggiorazioni.CreateHidden<MDMaggiorazioni>("Document.Doors.Doors.DynamicDocuments.Maggiorazioni", context);
		}

		public DBTDOORSMaggiorazioni DBTDOORSMaggiorazioni;

		public DBTDOORSMaggiorazioniDetail DBTDOORSMaggiorazioniDetail;

		public HKLProductCtg HKLProductCtg;

		public HKLProductSubCtg HKLProductSubCtg;

		public HKLCustSupp HKLCustSupp;

		public HKLItems HKLItems;

		public HKLDOORSAperture HKLDOORSAperture;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld__DEBUG;

		public Microarea.Framework.TBApplicationWrapper.MDataInt fld_FormMode;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_HeaderStripTitle;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_Title;

		public Microarea.Framework.TBApplicationWrapper.MDataInt fld_MoneyDecimal;

		public Microarea.Framework.TBApplicationWrapper.MDataInt fld_NAMoneyDecimal;

		public override void CreateComponents()
		{
			DBTDOORSMaggiorazioni = new DBTDOORSMaggiorazioni();
			this.AttachMaster(this.DBTDOORSMaggiorazioni);
			DBTDOORSMaggiorazioniDetail = new DBTDOORSMaggiorazioniDetail();
			this.AttachSlave(DBTDOORSMaggiorazioniDetail);
			HKLProductCtg = new HKLProductCtg();
			this.Add(this.HKLProductCtg, true);
			HKLProductCtg.DataMustExist = true;
			HKLProductCtg.AddChangedProperty("DataMustExist");
			HKLProductSubCtg = new HKLProductSubCtg();
			this.Add(this.HKLProductSubCtg, true);
			HKLProductSubCtg.DataMustExist = true;
			HKLProductSubCtg.AddChangedProperty("DataMustExist");
			HKLProductSubCtg.FilterQuery = "MA_ProductCtgSubCtg.Category == document.DBTDOORSMaggiorazioni.Prodctg";
			HKLProductSubCtg.AddChangedProperty("FilterQuery");
			HKLCustSupp = new HKLCustSupp();
			this.Add(this.HKLCustSupp, true);
			HKLCustSupp.DataMustExist = false;
			HKLCustSupp.AddChangedProperty("DataMustExist");
			HKLCustSupp.ParamCustSuppSel.Value = (Int16)0;
			HKLCustSupp.ParamDisabled.Value = (Int16)0;
			HKLItems = new HKLItems();
			this.Add(this.HKLItems, true);
			HKLItems.DataMustExist = false;
			HKLItems.AddChangedProperty("DataMustExist");
			HKLItems.CanAddOnFly = true;
			HKLItems.AddChangedProperty("CanAddOnFly");
			HKLItems.ParamAttivi.Value = (Int16)0;
			HKLDOORSAperture = new HKLDOORSAperture();
			this.Add(this.HKLDOORSAperture, true);
			HKLDOORSAperture.DataMustExist = true;
			HKLDOORSAperture.AddChangedProperty("DataMustExist");
			HKLDOORSAperture.CanAddOnFly = true;
			HKLDOORSAperture.AddChangedProperty("CanAddOnFly");
			HKLDOORSAperture.LinkedDocumentNamespace = "Document.Doors.Doors.DynamicDocuments.Aperture";
			HKLDOORSAperture.AddChangedProperty("LinkedDocumentNamespace");
			HKLDOORSAperture.PublicationNamespace = "HotKeyLink.Doors.Doors.DynamicDocuments.DOORSAperture";
			HKLDOORSAperture.AddChangedProperty("PublicationNamespace");
			this.fld__DEBUG = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("_DEBUG"));
			this.fld_FormMode = new Microarea.Framework.TBApplicationWrapper.MDataInt(this.GetFieldPtr("FormMode"));
			this.fld_HeaderStripTitle = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("HeaderStripTitle"));
			this.fld_Title = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Title"));
			this.fld_MoneyDecimal = new Microarea.Framework.TBApplicationWrapper.MDataInt(this.GetFieldPtr("MoneyDecimal"));
			this.fld_NAMoneyDecimal = new Microarea.Framework.TBApplicationWrapper.MDataInt(this.GetFieldPtr("NAMoneyDecimal"));
		}

		public override void ApplyResources()
		{
			Microarea.EasyBuilder.CustomizationComponentResourceManager resources = Strings.ResourceManager;
			resources.ApplyResources(HKLProductCtg, "HKLProductCtg");
			resources.ApplyResources(HKLProductSubCtg, "HKLProductSubCtg");
			resources.ApplyResources(HKLCustSupp, "HKLCustSupp");
			resources.ApplyResources(HKLItems, "HKLItems");
			resources.ApplyResources(HKLDOORSAperture, "HKLDOORSAperture");
		}

		public override void ClearComponents()
		{
			base.ClearComponents();
			DBTDOORSMaggiorazioni = null;
			DBTDOORSMaggiorazioniDetail = null;
			HKLProductCtg = null;
			HKLProductSubCtg = null;
			HKLCustSupp = null;
			HKLItems = null;
			HKLDOORSAperture = null;
			fld__DEBUG = null;
			fld_FormMode = null;
			fld_HeaderStripTitle = null;
			fld_Title = null;
			fld_MoneyDecimal = null;
			fld_NAMoneyDecimal = null;
		}
	}
	public class DBTDOORSMaggiorazioni : MDBTMaster
	{
		public DBTDOORSMaggiorazioni() : base("TAG_DOORS_Maggiorazioni", "DOORSMaggiorazioni", DocumentController.controller.Document, true)
		{
		}

		public DBTDOORSMaggiorazioni(System.IntPtr dbtPtr) : base(dbtPtr)
		{
		}

		public override Microarea.TaskBuilderNet.Interfaces.Model.IRecord Record
		{
			get
			{
				return TTAG_DOORS_Maggiorazioni;
			}
		}

		public TDBTDOORSMaggiorazioni_TAG_DOORS_Maggiorazioni TTAG_DOORS_Maggiorazioni;

		public override Microarea.TaskBuilderNet.Interfaces.Model.IRecord OldRecord
		{
			get
			{
				return OldTTAG_DOORS_Maggiorazioni;
			}
		}

		public TDBTDOORSMaggiorazioni_TAG_DOORS_Maggiorazioni OldTTAG_DOORS_Maggiorazioni;

		public virtual TDBTDOORSMaggiorazioni_TAG_DOORS_Maggiorazioni CastToMyRecord(Microarea.TaskBuilderNet.Interfaces.Model.IRecord record)
		{
			return (TDBTDOORSMaggiorazioni_TAG_DOORS_Maggiorazioni)record;
		}

		public override Microarea.Framework.TBApplicationWrapper.MDBTObject CreateAndAttach(System.IntPtr dbtPtr)
		{
			return new DBTDOORSMaggiorazioni(dbtPtr);
		}

		public override void CreateComponents()
		{
			TTAG_DOORS_Maggiorazioni = new TDBTDOORSMaggiorazioni_TAG_DOORS_Maggiorazioni(this.GetRecordPtr());
			this.Add(TTAG_DOORS_Maggiorazioni, true);
			OldTTAG_DOORS_Maggiorazioni = new TDBTDOORSMaggiorazioni_TAG_DOORS_Maggiorazioni(this.GetOldRecordPtr());
			this.Add(OldTTAG_DOORS_Maggiorazioni, true);
		}

		public override void ApplyResources()
		{
			Microarea.EasyBuilder.CustomizationComponentResourceManager resources = Strings.ResourceManager;
		}

		public override void ClearComponents()
		{
			base.ClearComponents();
			TTAG_DOORS_Maggiorazioni = null;
			OldTTAG_DOORS_Maggiorazioni = null;
		}
	}
	public class TDBTDOORSMaggiorazioni_TAG_DOORS_Maggiorazioni : Microarea.Framework.TBApplicationWrapper.MSqlRecord
	{
		public TDBTDOORSMaggiorazioni_TAG_DOORS_Maggiorazioni(System.IntPtr wrappedObject) : base(wrappedObject)
		{
		}

		public MDataDate fld_TBCreated;

		public MDataDate fld_TBModified;

		public MDataLng fld_TBCreatedID;

		public MDataLng fld_TBModifiedID;

		public MDataGuid fld_TBGuid;

		public MDataStr fld_Prodctg;

		public MDataStr fld_ProdSubCtg;

		public MDataStr fld_Customer;

		public MDataStr fld_DescriTabella;

		public MDataStr fld_DescriCat;

		public MDataStr fld_DescriSubCat;

		public MDataStr fld_RagSoc;

		public override void CreateComponents()
		{
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
			fld_Prodctg = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Prodctg"));
			this.Add(fld_Prodctg, false);
			fld_ProdSubCtg = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("ProdSubCtg"));
			this.Add(fld_ProdSubCtg, false);
			fld_Customer = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Customer"));
			this.Add(fld_Customer, false);
			fld_DescriTabella = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("DescriTabella"));
			this.Add(fld_DescriTabella, false);
			this.AddLocalField("DescriCat", "string", 64);
			fld_DescriCat = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("DescriCat"));
			this.Add(fld_DescriCat, false);
			this.AddLocalField("DescriSubCat", "string", 64);
			fld_DescriSubCat = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("DescriSubCat"));
			this.Add(fld_DescriSubCat, false);
			this.AddLocalField("RagSoc", "string", 150);
			fld_RagSoc = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("RagSoc"));
			this.Add(fld_RagSoc, false);
		}

		public override void ApplyResources()
		{
			Microarea.EasyBuilder.CustomizationComponentResourceManager resources = Strings.ResourceManager;
		}

		public override void ClearComponents()
		{
			base.ClearComponents();
			fld_TBCreated = null;
			fld_TBModified = null;
			fld_TBCreatedID = null;
			fld_TBModifiedID = null;
			fld_TBGuid = null;
			fld_Prodctg = null;
			fld_ProdSubCtg = null;
			fld_Customer = null;
			fld_DescriTabella = null;
			fld_DescriCat = null;
			fld_DescriSubCat = null;
			fld_RagSoc = null;
		}
	}
	public class DBTDOORSMaggiorazioniDetail : MDBTSlaveBuffered
	{
		public DBTDOORSMaggiorazioniDetail() : base("TAG_DOORS_MaggiorazioniDetail", "DOORSMaggiorazioniDetail", DocumentController.controller.Document, true)
		{
		}

		public DBTDOORSMaggiorazioniDetail(System.IntPtr dbtPtr) : base(dbtPtr)
		{
		}

		public override Microarea.TaskBuilderNet.Interfaces.Model.IRecord Record
		{
			get
			{
				return TTAG_DOORS_MaggiorazioniDetail;
			}
		}

		public TDBTDOORSMaggiorazioniDetail_TAG_DOORS_MaggiorazioniDetail TTAG_DOORS_MaggiorazioniDetail;

		public override Microarea.TaskBuilderNet.Interfaces.Model.IRecord OldRecord
		{
			get
			{
				return OldTTAG_DOORS_MaggiorazioniDetail;
			}
		}

		public TDBTDOORSMaggiorazioniDetail_TAG_DOORS_MaggiorazioniDetail OldTTAG_DOORS_MaggiorazioniDetail;

		public virtual TDBTDOORSMaggiorazioniDetail_TAG_DOORS_MaggiorazioniDetail CastToMyRecord(Microarea.TaskBuilderNet.Interfaces.Model.IRecord record)
		{
			return (TDBTDOORSMaggiorazioniDetail_TAG_DOORS_MaggiorazioniDetail)record;
		}

		public override Microarea.Framework.TBApplicationWrapper.MDBTObject CreateAndAttach(System.IntPtr dbtPtr)
		{
			return new DBTDOORSMaggiorazioniDetail(dbtPtr);
		}

		public virtual TDBTDOORSMaggiorazioniDetail_TAG_DOORS_MaggiorazioniDetail GetCurrentRow()
		{
			return (TDBTDOORSMaggiorazioniDetail_TAG_DOORS_MaggiorazioniDetail)this.GetCurrentRecord();
		}

		public virtual TDBTDOORSMaggiorazioniDetail_TAG_DOORS_MaggiorazioniDetail AddRow()
		{
			return (TDBTDOORSMaggiorazioniDetail_TAG_DOORS_MaggiorazioniDetail)this.AddRecord();
		}

		public virtual TDBTDOORSMaggiorazioniDetail_TAG_DOORS_MaggiorazioniDetail InsertRow(int rowNumber)
		{
			return (TDBTDOORSMaggiorazioniDetail_TAG_DOORS_MaggiorazioniDetail)this.InsertRecord(rowNumber);
		}

		public virtual TDBTDOORSMaggiorazioniDetail_TAG_DOORS_MaggiorazioniDetail GetRow(int rowNumber)
		{
			return (TDBTDOORSMaggiorazioniDetail_TAG_DOORS_MaggiorazioniDetail)this.GetRecord(rowNumber);
		}

		public virtual TDBTDOORSMaggiorazioniDetail_TAG_DOORS_MaggiorazioniDetail GetOldRow(int rowNumber)
		{
			return (TDBTDOORSMaggiorazioniDetail_TAG_DOORS_MaggiorazioniDetail)this.GetOldRecord(rowNumber);
		}

		public override void CreateComponents()
		{
			TTAG_DOORS_MaggiorazioniDetail = new TDBTDOORSMaggiorazioniDetail_TAG_DOORS_MaggiorazioniDetail(this.GetRecordPtr());
			this.Add(TTAG_DOORS_MaggiorazioniDetail, true);
			OldTTAG_DOORS_MaggiorazioniDetail = new TDBTDOORSMaggiorazioniDetail_TAG_DOORS_MaggiorazioniDetail(this.GetOldRecordPtr());
			this.Add(OldTTAG_DOORS_MaggiorazioniDetail, true);
		}

		public override void ApplyResources()
		{
			Microarea.EasyBuilder.CustomizationComponentResourceManager resources = Strings.ResourceManager;
		}

		public override void ClearComponents()
		{
			base.ClearComponents();
			TTAG_DOORS_MaggiorazioniDetail = null;
			OldTTAG_DOORS_MaggiorazioniDetail = null;
		}
	}
	public class TDBTDOORSMaggiorazioniDetail_TAG_DOORS_MaggiorazioniDetail : Microarea.Framework.TBApplicationWrapper.MSqlRecord
	{
		public TDBTDOORSMaggiorazioniDetail_TAG_DOORS_MaggiorazioniDetail(System.IntPtr wrappedObject) : base(wrappedObject)
		{
		}

		public MDataDate fld_TBCreated;

		public MDataDate fld_TBModified;

		public MDataLng fld_TBCreatedID;

		public MDataLng fld_TBModifiedID;

		public MDataStr fld_CtgProd;

		public MDataStr fld_SubCtgProd;

		public MDataStr fld_Customer;

		public MDataInt fld_Riga;

		public MDataStr fld_Item;

		public MDataStr fld_Descrizione;

		public MDataMon fld_Importo;

		public MDataEnum fld_TipoMaggiorazione;

		public MDataEnum fld_Dimensione;

		public MDataDbl fld_DaDim;

		public MDataDbl fld_ADim;

		public MDataStr fld_Apertura;

		public MDataDbl fld_OltreStandard;

		public MDataStr fld_DescriApertura;

		public override void CreateComponents()
		{
			fld_TBCreated = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("TBCreated"));
			this.Add(fld_TBCreated, false);
			fld_TBModified = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("TBModified"));
			this.Add(fld_TBModified, false);
			fld_TBCreatedID = new Microarea.Framework.TBApplicationWrapper.MDataLng(this.GetFieldPtr("TBCreatedID"));
			this.Add(fld_TBCreatedID, false);
			fld_TBModifiedID = new Microarea.Framework.TBApplicationWrapper.MDataLng(this.GetFieldPtr("TBModifiedID"));
			this.Add(fld_TBModifiedID, false);
			fld_CtgProd = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CtgProd"));
			this.Add(fld_CtgProd, false);
			fld_SubCtgProd = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("SubCtgProd"));
			this.Add(fld_SubCtgProd, false);
			fld_Customer = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Customer"));
			this.Add(fld_Customer, false);
			fld_Riga = new Microarea.Framework.TBApplicationWrapper.MDataInt(this.GetFieldPtr("Riga"));
			this.Add(fld_Riga, false);
			fld_Item = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Item"));
			this.Add(fld_Item, false);
			fld_Descrizione = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Descrizione"));
			this.Add(fld_Descrizione, false);
			fld_Importo = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("Importo"));
			this.Add(fld_Importo, false);
			fld_TipoMaggiorazione = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("TipoMaggiorazione"));
			this.Add(fld_TipoMaggiorazione, false);
			fld_Dimensione = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("Dimensione"));
			this.Add(fld_Dimensione, false);
			fld_DaDim = new Microarea.Framework.TBApplicationWrapper.MDataDbl(this.GetFieldPtr("DaDim"));
			this.Add(fld_DaDim, false);
			fld_ADim = new Microarea.Framework.TBApplicationWrapper.MDataDbl(this.GetFieldPtr("ADim"));
			this.Add(fld_ADim, false);
			fld_Apertura = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Apertura"));
			this.Add(fld_Apertura, false);
			fld_OltreStandard = new Microarea.Framework.TBApplicationWrapper.MDataDbl(this.GetFieldPtr("OltreStandard"));
			this.Add(fld_OltreStandard, false);
			this.AddLocalField("DescriApertura", "string", 64);
			fld_DescriApertura = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("DescriApertura"));
			this.Add(fld_DescriApertura, false);
		}

		public override void ApplyResources()
		{
			Microarea.EasyBuilder.CustomizationComponentResourceManager resources = Strings.ResourceManager;
		}

		public override void ClearComponents()
		{
			base.ClearComponents();
			fld_TBCreated = null;
			fld_TBModified = null;
			fld_TBCreatedID = null;
			fld_TBModifiedID = null;
			fld_CtgProd = null;
			fld_SubCtgProd = null;
			fld_Customer = null;
			fld_Riga = null;
			fld_Item = null;
			fld_Descrizione = null;
			fld_Importo = null;
			fld_TipoMaggiorazione = null;
			fld_Dimensione = null;
			fld_DaDim = null;
			fld_ADim = null;
			fld_Apertura = null;
			fld_OltreStandard = null;
			fld_DescriApertura = null;
		}
	}
	public class HKLProductCtg : Microarea.Framework.TBApplicationWrapper.MHotLink
	{
		public HKLProductCtg() : base(new Microarea.TaskBuilderNet.Core.Generic.NameSpace("HotKeyLink.ERP.Items.Dbl.ProductCtg"), "ProductCtg", DocumentController.controller.Document, true)
		{
		}

		public override Microarea.TaskBuilderNet.Interfaces.Model.IRecord Record
		{
			get
			{
				return TMA_ProductCtg;
			}
		}

		public THKLProductCtg_MA_ProductCtg TMA_ProductCtg;

		public virtual THKLProductCtg_MA_ProductCtg CastToMyRecord(Microarea.TaskBuilderNet.Interfaces.Model.IRecord record)
		{
			return (THKLProductCtg_MA_ProductCtg)record;
		}

		public MHotLinkSearch HKLProductCtg_ByKey;

		public MHotLinkSearch HKLProductCtg_ByDescription;

		public override void CreateComponents()
		{
			TMA_ProductCtg = new THKLProductCtg_MA_ProductCtg(this.GetRecordPtr());
			this.Add(TMA_ProductCtg, false);
			TMA_ProductCtg = new THKLProductCtg_MA_ProductCtg(this.GetRecordPtr());
			this.Add(TMA_ProductCtg, false);
			HKLProductCtg_ByKey = new Microarea.Framework.TBApplicationWrapper.MHotLinkSearch(this, true);
			HKLProductCtg_ByKey.UseInComboBox = true;
			HKLProductCtg_ByKey.AddChangedProperty("UseInComboBox");
			HKLProductCtg_ByKey.AssociatedButton = Microarea.Framework.TBApplicationWrapper.MHotLinkSearch.ButtonAssociation.UpperButton;
			HKLProductCtg_ByKey.AddChangedProperty("AssociatedButton");
			HKLProductCtg_ByKey.FieldName = "Category";
			HKLProductCtg_ByKey.AddChangedProperty("FieldName");
			HKLProductCtg_ByKey.AddChangedProperty("Description");
			HKLProductCtg_ByKey.Name = "ByKey";
			HKLProductCtg_ByKey.AddChangedProperty("Name");
			this.Add(HKLProductCtg_ByKey, true);
			HKLProductCtg_ByDescription = new Microarea.Framework.TBApplicationWrapper.MHotLinkSearch(this, true);
			HKLProductCtg_ByDescription.AssociatedButton = Microarea.Framework.TBApplicationWrapper.MHotLinkSearch.ButtonAssociation.LowerButton;
			HKLProductCtg_ByDescription.AddChangedProperty("AssociatedButton");
			HKLProductCtg_ByDescription.FieldName = "Description";
			HKLProductCtg_ByDescription.AddChangedProperty("FieldName");
			HKLProductCtg_ByDescription.AddChangedProperty("Description");
			HKLProductCtg_ByDescription.Name = "ByDescription";
			HKLProductCtg_ByDescription.AddChangedProperty("Name");
			this.Add(HKLProductCtg_ByDescription, true);
		}

		public override void ApplyResources()
		{
			Microarea.EasyBuilder.CustomizationComponentResourceManager resources = Strings.ResourceManager;
			resources.ApplyResources(HKLProductCtg_ByKey, "HKLProductCtg_ByKey");
			resources.ApplyResources(HKLProductCtg_ByDescription, "HKLProductCtg_ByDescription");
		}

		public override void ClearComponents()
		{
			base.ClearComponents();
			TMA_ProductCtg = null;
			TMA_ProductCtg = null;
			HKLProductCtg_ByKey = null;
			HKLProductCtg_ByDescription = null;
		}
	}
	public class THKLProductCtg_MA_ProductCtg : Microarea.Framework.TBApplicationWrapper.MSqlRecord
	{
		public THKLProductCtg_MA_ProductCtg(System.IntPtr wrappedObject) : base(wrappedObject)
		{
		}

		public MDataStr fld_Category;

		public MDataStr fld_Description;

		public MDataEnum fld_CodeType;

		public MDataStr fld_Notes;

		public MDataDate fld_TBCreated;

		public MDataDate fld_TBModified;

		public MDataLng fld_TBCreatedID;

		public MDataLng fld_TBModifiedID;

		public MDataGuid fld_TBGuid;

		public override void CreateComponents()
		{
			fld_Category = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Category"));
			this.Add(fld_Category, false);
			fld_Description = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Description"));
			this.Add(fld_Description, false);
			fld_CodeType = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("CodeType"));
			this.Add(fld_CodeType, false);
			fld_Notes = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Notes"));
			this.Add(fld_Notes, false);
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
			fld_Category = null;
			fld_Description = null;
			fld_CodeType = null;
			fld_Notes = null;
			fld_TBCreated = null;
			fld_TBModified = null;
			fld_TBCreatedID = null;
			fld_TBModifiedID = null;
			fld_TBGuid = null;
		}
	}
	public class HKLProductSubCtg : Microarea.Framework.TBApplicationWrapper.MHotLink
	{
		public HKLProductSubCtg() : base(new Microarea.TaskBuilderNet.Core.Generic.NameSpace("HotKeyLink.ERP.Items.Dbl.ProductSubCtg"), "ProductSubCtg", DocumentController.controller.Document, true)
		{
		}

		public override Microarea.TaskBuilderNet.Interfaces.Model.IRecord Record
		{
			get
			{
				return TMA_ProductCtgSubCtg;
			}
		}

		public THKLProductSubCtg_MA_ProductCtgSubCtg TMA_ProductCtgSubCtg;

		public virtual THKLProductSubCtg_MA_ProductCtgSubCtg CastToMyRecord(Microarea.TaskBuilderNet.Interfaces.Model.IRecord record)
		{
			return (THKLProductSubCtg_MA_ProductCtgSubCtg)record;
		}

		public MHotLinkSearch HKLProductSubCtg_ByKey;

		public MHotLinkSearch HKLProductSubCtg_ByDescription;

		public override void CreateComponents()
		{
			TMA_ProductCtgSubCtg = new THKLProductSubCtg_MA_ProductCtgSubCtg(this.GetRecordPtr());
			this.Add(TMA_ProductCtgSubCtg, false);
			TMA_ProductCtgSubCtg = new THKLProductSubCtg_MA_ProductCtgSubCtg(this.GetRecordPtr());
			this.Add(TMA_ProductCtgSubCtg, false);
			HKLProductSubCtg_ByKey = new Microarea.Framework.TBApplicationWrapper.MHotLinkSearch(this, true);
			HKLProductSubCtg_ByKey.UseInComboBox = true;
			HKLProductSubCtg_ByKey.AddChangedProperty("UseInComboBox");
			HKLProductSubCtg_ByKey.AssociatedButton = Microarea.Framework.TBApplicationWrapper.MHotLinkSearch.ButtonAssociation.UpperButton;
			HKLProductSubCtg_ByKey.AddChangedProperty("AssociatedButton");
			HKLProductSubCtg_ByKey.FieldName = "SubCategory";
			HKLProductSubCtg_ByKey.AddChangedProperty("FieldName");
			HKLProductSubCtg_ByKey.AddChangedProperty("Description");
			HKLProductSubCtg_ByKey.Name = "ByKey";
			HKLProductSubCtg_ByKey.AddChangedProperty("Name");
			this.Add(HKLProductSubCtg_ByKey, true);
			HKLProductSubCtg_ByDescription = new Microarea.Framework.TBApplicationWrapper.MHotLinkSearch(this, true);
			HKLProductSubCtg_ByDescription.AssociatedButton = Microarea.Framework.TBApplicationWrapper.MHotLinkSearch.ButtonAssociation.LowerButton;
			HKLProductSubCtg_ByDescription.AddChangedProperty("AssociatedButton");
			HKLProductSubCtg_ByDescription.FieldName = "Description";
			HKLProductSubCtg_ByDescription.AddChangedProperty("FieldName");
			HKLProductSubCtg_ByDescription.AddChangedProperty("Description");
			HKLProductSubCtg_ByDescription.Name = "ByDescription";
			HKLProductSubCtg_ByDescription.AddChangedProperty("Name");
			this.Add(HKLProductSubCtg_ByDescription, true);
		}

		public override void ApplyResources()
		{
			Microarea.EasyBuilder.CustomizationComponentResourceManager resources = Strings.ResourceManager;
			resources.ApplyResources(HKLProductSubCtg_ByKey, "HKLProductSubCtg_ByKey");
			resources.ApplyResources(HKLProductSubCtg_ByDescription, "HKLProductSubCtg_ByDescription");
		}

		public override void ClearComponents()
		{
			base.ClearComponents();
			TMA_ProductCtgSubCtg = null;
			TMA_ProductCtgSubCtg = null;
			HKLProductSubCtg_ByKey = null;
			HKLProductSubCtg_ByDescription = null;
		}
	}
	public class THKLProductSubCtg_MA_ProductCtgSubCtg : Microarea.Framework.TBApplicationWrapper.MSqlRecord
	{
		public THKLProductSubCtg_MA_ProductCtgSubCtg(System.IntPtr wrappedObject) : base(wrappedObject)
		{
		}

		public MDataStr fld_Category;

		public MDataStr fld_SubCategory;

		public MDataStr fld_Description;

		public MDataDate fld_TBCreated;

		public MDataDate fld_TBModified;

		public MDataLng fld_TBCreatedID;

		public MDataLng fld_TBModifiedID;

		public override void CreateComponents()
		{
			fld_Category = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Category"));
			this.Add(fld_Category, false);
			fld_SubCategory = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("SubCategory"));
			this.Add(fld_SubCategory, false);
			fld_Description = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Description"));
			this.Add(fld_Description, false);
			fld_TBCreated = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("TBCreated"));
			this.Add(fld_TBCreated, false);
			fld_TBModified = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("TBModified"));
			this.Add(fld_TBModified, false);
			fld_TBCreatedID = new Microarea.Framework.TBApplicationWrapper.MDataLng(this.GetFieldPtr("TBCreatedID"));
			this.Add(fld_TBCreatedID, false);
			fld_TBModifiedID = new Microarea.Framework.TBApplicationWrapper.MDataLng(this.GetFieldPtr("TBModifiedID"));
			this.Add(fld_TBModifiedID, false);
		}

		public override void ApplyResources()
		{
			Microarea.EasyBuilder.CustomizationComponentResourceManager resources = Strings.ResourceManager;
		}

		public override void ClearComponents()
		{
			base.ClearComponents();
			fld_Category = null;
			fld_SubCategory = null;
			fld_Description = null;
			fld_TBCreated = null;
			fld_TBModified = null;
			fld_TBCreatedID = null;
			fld_TBModifiedID = null;
		}
	}
	public class HKLCustSupp : Microarea.Framework.TBApplicationWrapper.MHotLink
	{
		public HKLCustSupp() : base(new Microarea.TaskBuilderNet.Core.Generic.NameSpace("HotKeyLink.ERP.CustomersSuppliers.Dbl.CustSupp"), "CustSupp", DocumentController.controller.Document, true)
		{
		}

		public override Microarea.TaskBuilderNet.Interfaces.Model.IRecord Record
		{
			get
			{
				return TMA_CustSupp;
			}
		}

		public THKLCustSupp_MA_CustSupp TMA_CustSupp;

		public virtual THKLCustSupp_MA_CustSupp CastToMyRecord(Microarea.TaskBuilderNet.Interfaces.Model.IRecord record)
		{
			return (THKLCustSupp_MA_CustSupp)record;
		}

		public MHotLinkSearch HKLCustSupp_ByKey;

		public MHotLinkSearch HKLCustSupp_ByDescription;

		[Microarea.TaskBuilderNet.Core.Localization.LocalizedCategoryAttribute("Parametri", typeof(Microarea.TaskBuilderNet.Core.EasyBuilder.EBCategories))]
		public Microarea.Framework.TBApplicationWrapper.MHotLinkParam ParamCustSuppSel
		{
			get
			{
				return this.GetParamByName("CustSuppSel");
			}
		}

		[Microarea.TaskBuilderNet.Core.Localization.LocalizedCategoryAttribute("Parametri", typeof(Microarea.TaskBuilderNet.Core.EasyBuilder.EBCategories))]
		public Microarea.Framework.TBApplicationWrapper.MHotLinkParam ParamDisabled
		{
			get
			{
				return this.GetParamByName("Disabled");
			}
		}

		public override void CreateComponents()
		{
			TMA_CustSupp = new THKLCustSupp_MA_CustSupp(this.GetRecordPtr());
			this.Add(TMA_CustSupp, false);
			TMA_CustSupp = new THKLCustSupp_MA_CustSupp(this.GetRecordPtr());
			this.Add(TMA_CustSupp, false);
			HKLCustSupp_ByKey = new Microarea.Framework.TBApplicationWrapper.MHotLinkSearch(this, true);
			HKLCustSupp_ByKey.UseInComboBox = true;
			HKLCustSupp_ByKey.AddChangedProperty("UseInComboBox");
			HKLCustSupp_ByKey.AssociatedButton = Microarea.Framework.TBApplicationWrapper.MHotLinkSearch.ButtonAssociation.UpperButton;
			HKLCustSupp_ByKey.AddChangedProperty("AssociatedButton");
			HKLCustSupp_ByKey.FieldName = "CustSupp";
			HKLCustSupp_ByKey.AddChangedProperty("FieldName");
			HKLCustSupp_ByKey.AddChangedProperty("Description");
			HKLCustSupp_ByKey.Name = "ByKey";
			HKLCustSupp_ByKey.AddChangedProperty("Name");
			this.Add(HKLCustSupp_ByKey, true);
			HKLCustSupp_ByDescription = new Microarea.Framework.TBApplicationWrapper.MHotLinkSearch(this, true);
			HKLCustSupp_ByDescription.AssociatedButton = Microarea.Framework.TBApplicationWrapper.MHotLinkSearch.ButtonAssociation.LowerButton;
			HKLCustSupp_ByDescription.AddChangedProperty("AssociatedButton");
			HKLCustSupp_ByDescription.FieldName = "MA_CustSupp.CompanyName";
			HKLCustSupp_ByDescription.AddChangedProperty("FieldName");
			HKLCustSupp_ByDescription.AddChangedProperty("Description");
			HKLCustSupp_ByDescription.Name = "ByDescription";
			HKLCustSupp_ByDescription.AddChangedProperty("Name");
			this.Add(HKLCustSupp_ByDescription, true);
		}

		public override void ApplyResources()
		{
			Microarea.EasyBuilder.CustomizationComponentResourceManager resources = Strings.ResourceManager;
			resources.ApplyResources(HKLCustSupp_ByKey, "HKLCustSupp_ByKey");
			resources.ApplyResources(HKLCustSupp_ByDescription, "HKLCustSupp_ByDescription");
		}

		public override void ClearComponents()
		{
			base.ClearComponents();
			TMA_CustSupp = null;
			TMA_CustSupp = null;
			HKLCustSupp_ByKey = null;
			HKLCustSupp_ByDescription = null;
		}
	}
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
	public class HKLItems : Microarea.Framework.TBApplicationWrapper.MHotLink
	{
		public HKLItems() : base(new Microarea.TaskBuilderNet.Core.Generic.NameSpace("HotKeyLink.ERP.Items.Dbl.Items"), "Items", DocumentController.controller.Document, true)
		{
		}

		public override Microarea.TaskBuilderNet.Interfaces.Model.IRecord Record
		{
			get
			{
				return TMA_Items;
			}
		}

		public THKLItems_MA_Items TMA_Items;

		public virtual THKLItems_MA_Items CastToMyRecord(Microarea.TaskBuilderNet.Interfaces.Model.IRecord record)
		{
			return (THKLItems_MA_Items)record;
		}

		public MHotLinkSearch HKLItems_ByKey;

		public MHotLinkSearch HKLItems_ByDescription;

		[Microarea.TaskBuilderNet.Core.Localization.LocalizedCategoryAttribute("Parametri", typeof(Microarea.TaskBuilderNet.Core.EasyBuilder.EBCategories))]
		public Microarea.Framework.TBApplicationWrapper.MHotLinkParam ParamAttivi
		{
			get
			{
				return this.GetParamByName("Attivi");
			}
		}

		public override void CreateComponents()
		{
			TMA_Items = new THKLItems_MA_Items(this.GetRecordPtr());
			this.Add(TMA_Items, true);
			TMA_Items = new THKLItems_MA_Items(this.GetRecordPtr());
			this.Add(TMA_Items, true);
			HKLItems_ByKey = new Microarea.Framework.TBApplicationWrapper.MHotLinkSearch(this, true);
			HKLItems_ByKey.UseInComboBox = true;
			HKLItems_ByKey.AddChangedProperty("UseInComboBox");
			HKLItems_ByKey.AssociatedButton = Microarea.Framework.TBApplicationWrapper.MHotLinkSearch.ButtonAssociation.UpperButton;
			HKLItems_ByKey.AddChangedProperty("AssociatedButton");
			HKLItems_ByKey.FieldName = "Item";
			HKLItems_ByKey.AddChangedProperty("FieldName");
			HKLItems_ByKey.AddChangedProperty("Description");
			HKLItems_ByKey.Name = "ByKey";
			HKLItems_ByKey.AddChangedProperty("Name");
			this.Add(HKLItems_ByKey, true);
			HKLItems_ByDescription = new Microarea.Framework.TBApplicationWrapper.MHotLinkSearch(this, true);
			HKLItems_ByDescription.AssociatedButton = Microarea.Framework.TBApplicationWrapper.MHotLinkSearch.ButtonAssociation.LowerButton;
			HKLItems_ByDescription.AddChangedProperty("AssociatedButton");
			HKLItems_ByDescription.FieldName = "Description";
			HKLItems_ByDescription.AddChangedProperty("FieldName");
			HKLItems_ByDescription.AddChangedProperty("Description");
			HKLItems_ByDescription.Name = "ByDescription";
			HKLItems_ByDescription.AddChangedProperty("Name");
			this.Add(HKLItems_ByDescription, true);
		}

		public override void ApplyResources()
		{
			Microarea.EasyBuilder.CustomizationComponentResourceManager resources = Strings.ResourceManager;
			resources.ApplyResources(HKLItems_ByKey, "HKLItems_ByKey");
			resources.ApplyResources(HKLItems_ByDescription, "HKLItems_ByDescription");
		}

		public override void ClearComponents()
		{
			base.ClearComponents();
			TMA_Items = null;
			TMA_Items = null;
			HKLItems_ByKey = null;
			HKLItems_ByDescription = null;
		}
	}
	public class THKLItems_MA_Items : Microarea.Framework.TBApplicationWrapper.MSqlRecord
	{
		public THKLItems_MA_Items(System.IntPtr wrappedObject) : base(wrappedObject)
		{
		}

		public MDataStr fld_Item;

		public MDataStr fld_SaleBarCode;

		public MDataStr fld_Description;

		public MDataBool fld_IsGood;

		public MDataStr fld_TaxCode;

		public MDataStr fld_BaseUoM;

		public MDataMon fld_BasePrice;

		public MDataPerc fld_Discount1;

		public MDataPerc fld_Discount2;

		public MDataStr fld_DiscountFormula;

		public MDataPerc fld_Markup;

		public MDataStr fld_ItemType;

		public MDataStr fld_CommodityCtg;

		public MDataStr fld_HomogeneousCtg;

		public MDataStr fld_CommissionCtg;

		public MDataStr fld_SaleOffset;

		public MDataStr fld_PurchaseOffset;

		public MDataDate fld_AvailabilityDate;

		public MDataEnum fld_SaleType;

		public MDataBool fld_HasCustomers;

		public MDataBool fld_HasSuppliers;

		public MDataStr fld_InternalNote;

		public MDataStr fld_PublicNote;

		public MDataStr fld_Producer;

		public MDataBool fld_UseSerialNo;

		public MDataStr fld_OldItem;

		public MDataBool fld_Disabled;

		public MDataStr fld_ProductCtg;

		public MDataStr fld_ProductSubCtg;

		public MDataBool fld_KitExpansion;

		public MDataBool fld_PostKitComponents;

		public MDataStr fld_Picture;

		public MDataDate fld_StandardCostDate;

		public MDataEnum fld_Nature;

		public MDataStr fld_SecondRateUoM;

		public MDataStr fld_SecondRate;

		public MDataEnum fld_PurchaseType;

		public MDataStr fld_ConsuptionOffset;

		public MDataBool fld_NotPostable;

		public MDataPerc fld_SalespersonComm;

		public MDataStr fld_CostCenter;

		public MDataBool fld_NoUoMSearch;

		public MDataStr fld_Job;

		public MDataStr fld_DescriptionText;

		public MDataBool fld_CanBeDisabled;

		public MDataStr fld_ProductLine;

		public MDataStr fld_ShortDescription;

		public MDataBool fld_BasePriceWithTax;

		public MDataBool fld_SubjectToWithholdingTax;

		public MDataDate fld_CreationDate;

		public MDataDate fld_ModificationDate;

		public MDataBool fld_NoAddDiscountInSaleDoc;

		public MDataStr fld_BarcodeSegment;

		public MDataBool fld_ReverseCharge;

		public MDataStr fld_RCTaxCode;

		public MDataBool fld_Draft;

		public MDataBool fld_Valorize;

		public MDataStr fld_FiscalUoM;

		public MDataStr fld_AccountingType;

		public MDataStr fld_AccountingRuleCode;

		public MDataBool fld_NoPaymDiscountInDoc;

		public MDataBool fld_ToBeDiscontinued;

		public MDataLng fld_LastSubIdNotes;

		public MDataBool fld_l_NoBOM;

		public MDataQty fld_l_OnHand;

		public MDataQty fld_l_BookInventory;

		public MDataBool fld_AdditionalCharge;

		public MDataStr fld_ISBN;

		public MDataStr fld_AuthorCode;

		public MDataMon fld_CoverPrice;

		public MDataStr fld_EITypeCode;

		public MDataStr fld_EIValueCode;

		public MDataEnum fld_EITypeLine;

		public MDataStr fld_AswAddChargeCode;

		public MDataStr fld_GroupItemCode;

		public MDataDate fld_TBCreated;

		public MDataDate fld_TBModified;

		public MDataLng fld_TBCreatedID;

		public MDataLng fld_TBModifiedID;

		public MDataGuid fld_TBGuid;

		public MDataStr fld_DoorsApertura;

		public MDataStr fld_DoorsNote;

		public MDataDbl fld_DoorsLarghezza;

		public MDataDbl fld_DoorsAltezza;

		public MDataStr fld_DoorsFinitura;

		public MDataStr fld_DoorsBattuta;

		public MDataStr fld_DoorsTipoTelaio;

		public MDataDbl fld_DoorsSpessore;

		public override void CreateComponents()
		{
			fld_Item = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Item"));
			this.Add(fld_Item, false);
			fld_SaleBarCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("SaleBarCode"));
			this.Add(fld_SaleBarCode, false);
			fld_Description = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Description"));
			this.Add(fld_Description, false);
			fld_IsGood = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("IsGood"));
			this.Add(fld_IsGood, false);
			fld_TaxCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("TaxCode"));
			this.Add(fld_TaxCode, false);
			fld_BaseUoM = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("BaseUoM"));
			this.Add(fld_BaseUoM, false);
			fld_BasePrice = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("BasePrice"));
			this.Add(fld_BasePrice, false);
			fld_Discount1 = new Microarea.Framework.TBApplicationWrapper.MDataPerc(this.GetFieldPtr("Discount1"));
			this.Add(fld_Discount1, false);
			fld_Discount2 = new Microarea.Framework.TBApplicationWrapper.MDataPerc(this.GetFieldPtr("Discount2"));
			this.Add(fld_Discount2, false);
			fld_DiscountFormula = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("DiscountFormula"));
			this.Add(fld_DiscountFormula, false);
			fld_Markup = new Microarea.Framework.TBApplicationWrapper.MDataPerc(this.GetFieldPtr("Markup"));
			this.Add(fld_Markup, false);
			fld_ItemType = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("ItemType"));
			this.Add(fld_ItemType, false);
			fld_CommodityCtg = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CommodityCtg"));
			this.Add(fld_CommodityCtg, false);
			fld_HomogeneousCtg = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("HomogeneousCtg"));
			this.Add(fld_HomogeneousCtg, false);
			fld_CommissionCtg = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CommissionCtg"));
			this.Add(fld_CommissionCtg, false);
			fld_SaleOffset = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("SaleOffset"));
			this.Add(fld_SaleOffset, false);
			fld_PurchaseOffset = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("PurchaseOffset"));
			this.Add(fld_PurchaseOffset, false);
			fld_AvailabilityDate = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("AvailabilityDate"));
			this.Add(fld_AvailabilityDate, false);
			fld_SaleType = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("SaleType"));
			this.Add(fld_SaleType, false);
			fld_HasCustomers = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("HasCustomers"));
			this.Add(fld_HasCustomers, false);
			fld_HasSuppliers = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("HasSuppliers"));
			this.Add(fld_HasSuppliers, false);
			fld_InternalNote = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("InternalNote"));
			this.Add(fld_InternalNote, false);
			fld_PublicNote = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("PublicNote"));
			this.Add(fld_PublicNote, false);
			fld_Producer = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Producer"));
			this.Add(fld_Producer, false);
			fld_UseSerialNo = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("UseSerialNo"));
			this.Add(fld_UseSerialNo, false);
			fld_OldItem = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("OldItem"));
			this.Add(fld_OldItem, false);
			fld_Disabled = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("Disabled"));
			this.Add(fld_Disabled, false);
			fld_ProductCtg = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("ProductCtg"));
			this.Add(fld_ProductCtg, false);
			fld_ProductSubCtg = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("ProductSubCtg"));
			this.Add(fld_ProductSubCtg, false);
			fld_KitExpansion = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("KitExpansion"));
			this.Add(fld_KitExpansion, false);
			fld_PostKitComponents = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("PostKitComponents"));
			this.Add(fld_PostKitComponents, false);
			fld_Picture = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Picture"));
			this.Add(fld_Picture, false);
			fld_StandardCostDate = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("StandardCostDate"));
			this.Add(fld_StandardCostDate, false);
			fld_Nature = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("Nature"));
			this.Add(fld_Nature, false);
			fld_SecondRateUoM = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("SecondRateUoM"));
			this.Add(fld_SecondRateUoM, false);
			fld_SecondRate = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("SecondRate"));
			this.Add(fld_SecondRate, false);
			fld_PurchaseType = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("PurchaseType"));
			this.Add(fld_PurchaseType, false);
			fld_ConsuptionOffset = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("ConsuptionOffset"));
			this.Add(fld_ConsuptionOffset, false);
			fld_NotPostable = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("NotPostable"));
			this.Add(fld_NotPostable, false);
			fld_SalespersonComm = new Microarea.Framework.TBApplicationWrapper.MDataPerc(this.GetFieldPtr("SalespersonComm"));
			this.Add(fld_SalespersonComm, false);
			fld_CostCenter = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CostCenter"));
			this.Add(fld_CostCenter, false);
			fld_NoUoMSearch = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("NoUoMSearch"));
			this.Add(fld_NoUoMSearch, false);
			fld_Job = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Job"));
			this.Add(fld_Job, false);
			fld_DescriptionText = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("DescriptionText"));
			this.Add(fld_DescriptionText, false);
			fld_CanBeDisabled = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("CanBeDisabled"));
			this.Add(fld_CanBeDisabled, false);
			fld_ProductLine = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("ProductLine"));
			this.Add(fld_ProductLine, false);
			fld_ShortDescription = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("ShortDescription"));
			this.Add(fld_ShortDescription, false);
			fld_BasePriceWithTax = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("BasePriceWithTax"));
			this.Add(fld_BasePriceWithTax, false);
			fld_SubjectToWithholdingTax = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("SubjectToWithholdingTax"));
			this.Add(fld_SubjectToWithholdingTax, false);
			fld_CreationDate = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("CreationDate"));
			this.Add(fld_CreationDate, false);
			fld_ModificationDate = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("ModificationDate"));
			this.Add(fld_ModificationDate, false);
			fld_NoAddDiscountInSaleDoc = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("NoAddDiscountInSaleDoc"));
			this.Add(fld_NoAddDiscountInSaleDoc, false);
			fld_BarcodeSegment = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("BarcodeSegment"));
			this.Add(fld_BarcodeSegment, false);
			fld_ReverseCharge = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("ReverseCharge"));
			this.Add(fld_ReverseCharge, false);
			fld_RCTaxCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("RCTaxCode"));
			this.Add(fld_RCTaxCode, false);
			fld_Draft = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("Draft"));
			this.Add(fld_Draft, false);
			fld_Valorize = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("Valorize"));
			this.Add(fld_Valorize, false);
			fld_FiscalUoM = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("FiscalUoM"));
			this.Add(fld_FiscalUoM, false);
			fld_AccountingType = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("AccountingType"));
			this.Add(fld_AccountingType, false);
			fld_AccountingRuleCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("AccountingRuleCode"));
			this.Add(fld_AccountingRuleCode, false);
			fld_NoPaymDiscountInDoc = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("NoPaymDiscountInDoc"));
			this.Add(fld_NoPaymDiscountInDoc, false);
			fld_ToBeDiscontinued = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("ToBeDiscontinued"));
			this.Add(fld_ToBeDiscontinued, false);
			fld_LastSubIdNotes = new Microarea.Framework.TBApplicationWrapper.MDataLng(this.GetFieldPtr("LastSubIdNotes"));
			this.Add(fld_LastSubIdNotes, false);
			fld_l_NoBOM = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("l_NoBOM"));
			this.Add(fld_l_NoBOM, false);
			fld_l_OnHand = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("l_OnHand"));
			this.Add(fld_l_OnHand, false);
			fld_l_BookInventory = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("l_BookInventory"));
			this.Add(fld_l_BookInventory, false);
			fld_AdditionalCharge = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("AdditionalCharge"));
			this.Add(fld_AdditionalCharge, false);
			fld_ISBN = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("ISBN"));
			this.Add(fld_ISBN, false);
			fld_AuthorCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("AuthorCode"));
			this.Add(fld_AuthorCode, false);
			fld_CoverPrice = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("CoverPrice"));
			this.Add(fld_CoverPrice, false);
			fld_EITypeCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("EITypeCode"));
			this.Add(fld_EITypeCode, false);
			fld_EIValueCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("EIValueCode"));
			this.Add(fld_EIValueCode, false);
			fld_EITypeLine = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("EITypeLine"));
			this.Add(fld_EITypeLine, false);
			fld_AswAddChargeCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("AswAddChargeCode"));
			this.Add(fld_AswAddChargeCode, false);
			fld_GroupItemCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("GroupItemCode"));
			this.Add(fld_GroupItemCode, false);
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
			fld_DoorsApertura = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("DoorsApertura"));
			this.Add(fld_DoorsApertura, false);
			fld_DoorsNote = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("DoorsNote"));
			this.Add(fld_DoorsNote, false);
			fld_DoorsLarghezza = new Microarea.Framework.TBApplicationWrapper.MDataDbl(this.GetFieldPtr("DoorsLarghezza"));
			this.Add(fld_DoorsLarghezza, false);
			fld_DoorsAltezza = new Microarea.Framework.TBApplicationWrapper.MDataDbl(this.GetFieldPtr("DoorsAltezza"));
			this.Add(fld_DoorsAltezza, false);
			fld_DoorsFinitura = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("DoorsFinitura"));
			this.Add(fld_DoorsFinitura, false);
			fld_DoorsBattuta = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("DoorsBattuta"));
			this.Add(fld_DoorsBattuta, false);
			fld_DoorsTipoTelaio = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("DoorsTipoTelaio"));
			this.Add(fld_DoorsTipoTelaio, false);
			fld_DoorsSpessore = new Microarea.Framework.TBApplicationWrapper.MDataDbl(this.GetFieldPtr("DoorsSpessore"));
			this.Add(fld_DoorsSpessore, false);
		}

		public override void ApplyResources()
		{
			Microarea.EasyBuilder.CustomizationComponentResourceManager resources = Strings.ResourceManager;
		}

		public override void ClearComponents()
		{
			base.ClearComponents();
			fld_Item = null;
			fld_SaleBarCode = null;
			fld_Description = null;
			fld_IsGood = null;
			fld_TaxCode = null;
			fld_BaseUoM = null;
			fld_BasePrice = null;
			fld_Discount1 = null;
			fld_Discount2 = null;
			fld_DiscountFormula = null;
			fld_Markup = null;
			fld_ItemType = null;
			fld_CommodityCtg = null;
			fld_HomogeneousCtg = null;
			fld_CommissionCtg = null;
			fld_SaleOffset = null;
			fld_PurchaseOffset = null;
			fld_AvailabilityDate = null;
			fld_SaleType = null;
			fld_HasCustomers = null;
			fld_HasSuppliers = null;
			fld_InternalNote = null;
			fld_PublicNote = null;
			fld_Producer = null;
			fld_UseSerialNo = null;
			fld_OldItem = null;
			fld_Disabled = null;
			fld_ProductCtg = null;
			fld_ProductSubCtg = null;
			fld_KitExpansion = null;
			fld_PostKitComponents = null;
			fld_Picture = null;
			fld_StandardCostDate = null;
			fld_Nature = null;
			fld_SecondRateUoM = null;
			fld_SecondRate = null;
			fld_PurchaseType = null;
			fld_ConsuptionOffset = null;
			fld_NotPostable = null;
			fld_SalespersonComm = null;
			fld_CostCenter = null;
			fld_NoUoMSearch = null;
			fld_Job = null;
			fld_DescriptionText = null;
			fld_CanBeDisabled = null;
			fld_ProductLine = null;
			fld_ShortDescription = null;
			fld_BasePriceWithTax = null;
			fld_SubjectToWithholdingTax = null;
			fld_CreationDate = null;
			fld_ModificationDate = null;
			fld_NoAddDiscountInSaleDoc = null;
			fld_BarcodeSegment = null;
			fld_ReverseCharge = null;
			fld_RCTaxCode = null;
			fld_Draft = null;
			fld_Valorize = null;
			fld_FiscalUoM = null;
			fld_AccountingType = null;
			fld_AccountingRuleCode = null;
			fld_NoPaymDiscountInDoc = null;
			fld_ToBeDiscontinued = null;
			fld_LastSubIdNotes = null;
			fld_l_NoBOM = null;
			fld_l_OnHand = null;
			fld_l_BookInventory = null;
			fld_AdditionalCharge = null;
			fld_ISBN = null;
			fld_AuthorCode = null;
			fld_CoverPrice = null;
			fld_EITypeCode = null;
			fld_EIValueCode = null;
			fld_EITypeLine = null;
			fld_AswAddChargeCode = null;
			fld_GroupItemCode = null;
			fld_TBCreated = null;
			fld_TBModified = null;
			fld_TBCreatedID = null;
			fld_TBModifiedID = null;
			fld_TBGuid = null;
			fld_DoorsApertura = null;
			fld_DoorsNote = null;
			fld_DoorsLarghezza = null;
			fld_DoorsAltezza = null;
			fld_DoorsFinitura = null;
			fld_DoorsBattuta = null;
			fld_DoorsTipoTelaio = null;
			fld_DoorsSpessore = null;
		}
	}
	public class HKLDOORSAperture : Microarea.Framework.TBApplicationWrapper.MHotLink
	{
		public HKLDOORSAperture() : base("TAG_DOORS_Aperture", "DOORSAperture", DocumentController.controller.Document, true)
		{
		}

		public override Microarea.TaskBuilderNet.Interfaces.Model.IRecord Record
		{
			get
			{
				return TTAG_DOORS_Aperture;
			}
		}

		public THKLDOORSAperture_TAG_DOORS_Aperture TTAG_DOORS_Aperture;

		public virtual THKLDOORSAperture_TAG_DOORS_Aperture CastToMyRecord(Microarea.TaskBuilderNet.Interfaces.Model.IRecord record)
		{
			return (THKLDOORSAperture_TAG_DOORS_Aperture)record;
		}

		public MHotLinkSearch HKLDOORSAperture_ByKey;

		public MHotLinkSearch HKLDOORSAperture_ByDescription;

		public override void CreateComponents()
		{
			TTAG_DOORS_Aperture = new THKLDOORSAperture_TAG_DOORS_Aperture(this.GetRecordPtr());
			this.Add(TTAG_DOORS_Aperture, true);
			TTAG_DOORS_Aperture = new THKLDOORSAperture_TAG_DOORS_Aperture(this.GetRecordPtr());
			this.Add(TTAG_DOORS_Aperture, true);
			HKLDOORSAperture_ByKey = new Microarea.Framework.TBApplicationWrapper.MHotLinkSearch(this, false);
			HKLDOORSAperture_ByKey.UseInComboBox = true;
			HKLDOORSAperture_ByKey.AddChangedProperty("UseInComboBox");
			HKLDOORSAperture_ByKey.AssociatedButton = Microarea.Framework.TBApplicationWrapper.MHotLinkSearch.ButtonAssociation.UpperButton;
			HKLDOORSAperture_ByKey.AddChangedProperty("AssociatedButton");
			HKLDOORSAperture_ByKey.FieldName = "CodiceAp";
			HKLDOORSAperture_ByKey.AddChangedProperty("FieldName");
			HKLDOORSAperture_ByKey.AddChangedProperty("Description");
			HKLDOORSAperture_ByKey.Name = "ByKey";
			HKLDOORSAperture_ByKey.AddChangedProperty("Name");
			this.Add(HKLDOORSAperture_ByKey, true);
			HKLDOORSAperture_ByDescription = new Microarea.Framework.TBApplicationWrapper.MHotLinkSearch(this, false);
			HKLDOORSAperture_ByDescription.AssociatedButton = Microarea.Framework.TBApplicationWrapper.MHotLinkSearch.ButtonAssociation.LowerButton;
			HKLDOORSAperture_ByDescription.AddChangedProperty("AssociatedButton");
			HKLDOORSAperture_ByDescription.FieldName = "Descrizione";
			HKLDOORSAperture_ByDescription.AddChangedProperty("FieldName");
			HKLDOORSAperture_ByDescription.AddChangedProperty("Description");
			HKLDOORSAperture_ByDescription.Name = "ByDescription";
			HKLDOORSAperture_ByDescription.AddChangedProperty("Name");
			this.Add(HKLDOORSAperture_ByDescription, true);
		}

		public override void ApplyResources()
		{
			Microarea.EasyBuilder.CustomizationComponentResourceManager resources = Strings.ResourceManager;
			resources.ApplyResources(HKLDOORSAperture_ByKey, "HKLDOORSAperture_ByKey");
			resources.ApplyResources(HKLDOORSAperture_ByDescription, "HKLDOORSAperture_ByDescription");
		}

		public override void ClearComponents()
		{
			base.ClearComponents();
			TTAG_DOORS_Aperture = null;
			TTAG_DOORS_Aperture = null;
			HKLDOORSAperture_ByKey = null;
			HKLDOORSAperture_ByDescription = null;
		}
	}
	public class THKLDOORSAperture_TAG_DOORS_Aperture : Microarea.Framework.TBApplicationWrapper.MSqlRecord
	{
		public THKLDOORSAperture_TAG_DOORS_Aperture(System.IntPtr wrappedObject) : base(wrappedObject)
		{
		}

		public MDataDate fld_TBCreated;

		public MDataDate fld_TBModified;

		public MDataLng fld_TBCreatedID;

		public MDataLng fld_TBModifiedID;

		public MDataGuid fld_TBGuid;

		public MDataStr fld_CodiceAp;

		public MDataStr fld_Descrizione;

		public override void CreateComponents()
		{
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
			fld_CodiceAp = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CodiceAp"));
			this.Add(fld_CodiceAp, false);
			fld_Descrizione = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Descrizione"));
			this.Add(fld_Descrizione, false);
		}

		public override void ApplyResources()
		{
			Microarea.EasyBuilder.CustomizationComponentResourceManager resources = Strings.ResourceManager;
		}

		public override void ClearComponents()
		{
			base.ClearComponents();
			fld_TBCreated = null;
			fld_TBModified = null;
			fld_TBCreatedID = null;
			fld_TBModifiedID = null;
			fld_TBGuid = null;
			fld_CodiceAp = null;
			fld_Descrizione = null;
		}
	}
}

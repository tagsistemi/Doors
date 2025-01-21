//using BusinessObjects.Doors.Doors.DynamicDocuments.DoorsConf;
//using BusinessObjects.Doors.Doors.DynamicDocuments.ConfiguratoreDoors;
using Wv2Edge;
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
using RestSharp.Validation;
using RestSharp.Serializers;
using RestSharp.Contrib;
using RestSharp.Extensions;
using RestSharp.Deserializers;
using RestSharp.Authenticators.OAuth;
using RestSharp.Authenticators;
using RestSharp;
using OpenCartGateClasses;
using Newtonsoft.Json.Bson;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Core.Raw;
using Microsoft.Web.WebView2.Core;
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
using ElaboratoreOrdiniClasses;
using DoorsAddoOnLibrary.Models;
using DoorsAddoOnLibrary.BillOfMaterialsComponents;
using DoorsAddoOnLibrary.LoginManager;
using DoorsAddoOnLibrary.TbServices;
using DoorsAddoOnLibrary;
using DevExpress.XtraVerticalGrid.Utils;
using DevExpress.XtraVerticalGrid.ViewInfo;
using DevExpress.XtraVerticalGrid.Events;
using DevExpress.XtraVerticalGrid.Editors;
using DevExpress.XtraVerticalGrid.Painters;
using DevExpress.XtraVerticalGrid.Localization;
using DevExpress.XtraVerticalGrid.Internal;
using DevExpress.XtraVerticalGrid.Design;
using DevExpress.XtraVerticalGrid.Data;
using DevExpress.XtraVerticalGrid.Rows;
using DevExpress.XtraVerticalGrid.Blending;
using DevExpress.XtraVerticalGrid;
using DevExpress.XtraVerticalGrid.Accessibility;
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
using DevExpress.XtraEditors.Controls.Rtf;
using DevExpress.XtraFilterEditor.IntelliSense;
using DevExpress.XtraFilterEditor;
using DevExpress.XtraRichEdit.Painters;
using DevExpress.XtraRichEdit.Forms.Design;
using DevExpress.XtraRichEdit.API.RichTextBox;
using DevExpress.XtraRichEdit.API.Word;
using DevExpress.API.Mso;
using DevExpress.XtraPrinting.Preview.Native.Galleries;
using DevExpress.XtraPrinting.Preview.Native;
using DevExpress.XtraPrinting.Links;
using DevExpress.XtraPrinting.Control;
using DevExpress.XtraPrinting.Control.Native;
using DevExpress.XtraPrinting.CodedUISupport;
using DevExpress.XtraPrinting.Native.WinControls;
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
using DevExpress.XtraEditors.Design;
using DevExpress.XtraEditors.Frames;
using DevExpress.XtraEditors.Customization;
using DevExpress.XtraEditors.ListControls;
using DevExpress.XtraEditors.Container;
using DevExpress.XtraEditors.CodedUISupport;
using DevExpress.XtraEditors.ButtonPanel;
using DevExpress.XtraEditors.Senders;
using DevExpress.XtraEditors.Persistent;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraBars.Ribbon.Customization;
using DevExpress.XtraBars.Docking.Controller;
using DevExpress.XtraBars.Docking2010.Dragging.WindowsUI;
using DevExpress.XtraBars.Docking2010.Views.NoDocuments;
using DevExpress.XtraBars.Docking2010.Views.NativeMdi;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Commands.Internal;
using DevExpress.XtraBars.Commands.Ribbon;
using DevExpress.XtraBars.Commands;
using DevExpress.XtraBars.Commands.Design;
using DevExpress.XtraEditors.ColorPick.Popup.Galleries;
using DevExpress.XtraBars.ColorPick.Popup;
using DevExpress.XtraEditors.ColorPick.Picker;
using DevExpress.XtraBars.CodedUISupport;
using DevExpress.XtraBars.Editors;
using DevExpress.XtraTabbedMdi;
using DevExpress.XtraBars.Ribbon.Helpers;
using DevExpress.XtraBars.Ribbon.Internal;
using DevExpress.XtraBars.Ribbon.Gallery;
using DevExpress.XtraBars.Styles;
using DevExpress.XtraBars.Ribbon.Drawing;
using DevExpress.XtraBars.Ribbon.ViewInfo;
using DevExpress.XtraBars.Ribbon.Handler;
using DevExpress.XtraBars.Ribbon.Accessible;
using DevExpress.XtraBars.Localization;
using DevExpress.XtraBars.Design;
using DevExpress.XtraBars.Docking2010.Customization;
using DevExpress.XtraBars.InternalItems;
using DevExpress.XtraBars.Docking.Paint;
using DevExpress.XtraBars.Docking.Helpers;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars.Docking2010.Dragging;
using DevExpress.XtraBars.Docking2010;
using DevExpress.XtraBars.Docking2010.DragEngine;
using DevExpress.XtraBars.Docking2010.Views.Tabbed;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraBars.Docking2010.Base;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Customization.Helpers;
using DevExpress.XtraBars.Helpers.Docking;
using DevExpress.XtraBars.Forms;
using DevExpress.XtraBars.Registration;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraBars.ViewInfo;
using DevExpress.XtraBars.Objects;
using DevExpress.XtraBars.Native;
using DevExpress.XtraBars.MessageFilter;
using DevExpress.XtraBars.Painters;
using DevExpress.XtraBars.Utils;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Controls;
using DevExpress.XtraBars.Alerter;
using DevExpress.XtraBars.Customization;
using DevExpress.XtraBars.Accessible;
using DevExpress.Utils.UI.Localization;
using DevExpress.Utils.UI;
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
using DevExpress.XtraRichEdit.Internal.SimpleLayout;
using DevExpress.XtraRichEdit.Internal.ReadingLayout;
using DevExpress.XtraRichEdit.Internal.DraftLayout;
using DevExpress.XtraRichEdit.Internal.PrintLayout;
using DevExpress.XtraRichEdit.Design;
using DevExpress.XtraRichEdit.SyntaxEdit.Commands.Internal;
using DevExpress.XtraRichEdit.SyntaxEdit.Commands;
using DevExpress.XtraRichEdit.SyntaxEdit;
using DevExpress.XtraRichEdit.SyntaxEdit.Services.Implementation;
using DevExpress.XtraRichEdit.SpellChecker;
using DevExpress.XtraRichEdit.Services.Implementation;
using DevExpress.XtraRichEdit.Ruler;
using DevExpress.XtraPrinting.Native.RichText;
using DevExpress.XtraPrinting.Exports;
using DevExpress.XtraRichEdit.Printing;
using DevExpress.XtraRichEdit.Utils.NumberConverters;
using DevExpress.XtraRichEdit.Mouse;
using DevExpress.XtraRichEdit.Localization.Internal;
using DevExpress.XtraRichEdit.Localization;
using DevExpress.XtraRichEdit.Keyboard;
using DevExpress.XtraRichEdit.Design.Internal;
using DevExpress.XtraRichEdit.Menu;
using DevExpress.XtraRichEdit.Forms;
using DevExpress.XtraRichEdit.Fields.Expression;
using DevExpress.XtraRichEdit.Fields;
using DevExpress.XtraRichEdit.Model.History;
using DevExpress.XtraRichEdit.Layout.TableLayout;
using DevExpress.XtraRichEdit.Layout.Engine;
using DevExpress.XtraRichEdit.Layout.Export;
using DevExpress.XtraRichEdit.Import.Xaml;
using DevExpress.XtraRichEdit.Export.Xaml;
using DevExpress.XtraRichEdit.Import.WordML;
using DevExpress.XtraRichEdit.Export.WordML;
using DevExpress.XtraRichEdit.Import.Rtf.Tables;
using DevExpress.XtraRichEdit.Import.Rtf;
using DevExpress.XtraRichEdit.Export.PlainText;
using DevExpress.XtraRichEdit.Import.OpenXml;
using DevExpress.XtraRichEdit.Export.OpenXml;
using DevExpress.XtraRichEdit.Import.OpenDocument;
using DevExpress.XtraRichEdit.Export.OpenDocument;
using DevExpress.XtraRichEdit.Import.Mht;
using DevExpress.XtraRichEdit.Export.Mht;
using DevExpress.XtraRichEdit.Import.Html;
using DevExpress.XtraRichEdit.Import.EPub;
using DevExpress.XtraRichEdit.Export.Html;
using DevExpress.XtraRichEdit.Export.EPub;
using DevExpress.XtraRichEdit.Services;
using DevExpress.XtraRichEdit.Import;
using DevExpress.XtraRichEdit.Import.Doc;
using DevExpress.XtraRichEdit.Tables.Native;
using DevExpress.XtraRichEdit.Export.Doc;
using DevExpress.XtraRichEdit.Native;
using DevExpress.XtraRichEdit.Export;
using DevExpress.XtraRichEdit.Utils;
using DevExpress.XtraRichEdit.Commands.Helper;
using DevExpress.XtraRichEdit.Commands.Internal;
using DevExpress.XtraRichEdit.Commands;
using DevExpress.XtraRichEdit.Drawing;
using DevExpress.XtraRichEdit.Layout;
using DevExpress.XtraRichEdit.Internal;
using DevExpress.XtraRichEdit.API.Native.Implementation;
using DevExpress.XtraRichEdit.API.Native;
using DevExpress.XtraRichEdit.API.Internal;
using DevExpress.XtraRichEdit.Model;
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
using DevExpress.Office.Services;
using DevExpress.Office.Services.Implementation;
using DevExpress.Office.Layout.Export;
using DevExpress.Office.Printing;
using DevExpress.Office.PInvoke;
using DevExpress.Office.Localization.Internal;
using DevExpress.Office.Localization;
using DevExpress.Office.Drawing;
using DevExpress.XtraRichEdit;
using DevExpress.Office.History;
using DevExpress.Office.Model;
using DevExpress.Office.Layout;
using DevExpress.Utils.StructuredStorage.Writer;
using DevExpress.Utils.StructuredStorage.Internal.Writer;
using DevExpress.Utils.StructuredStorage.Internal.Reader;
using DevExpress.Utils.StructuredStorage.Reader;
using DevExpress.Utils.StructuredStorage.Internal;
using DevExpress.Office.Utils;
using DevExpress.Office.Import;
using DevExpress.Office.Export;
using DevExpress.Office;
using DevExpress.Office.Internal;
using DevExpress.Office.API.Internal;
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
using Cryptdll.classi;
using Cryptdll;
using MRG.Controls.UI;
using BusinessObjects.ERP.Variants.Documents.Variants;
using BusinessObjects.Doors.Doors.DynamicDocuments.DoorsConf;
using BusinessObjects.Doors.Doors.DynamicDocuments.Configurazioni;
using BusinessObjects.Doors.Doors.DynamicDocuments.ConfiguratoreDoors;
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

namespace BusinessObjects.ERP.BillOfMaterials.Documents.BOMNavigation
{
	public static class Strings
	{
		public static Microarea.EasyBuilder.CustomizationComponentResourceManager ResourceManager = new Microarea.EasyBuilder.CustomizationComponentResourceManager(typeof(Strings));
	}
	[Microarea.TaskBuilderNet.Core.EasyBuilder.DocumentNamespaceAttribute("Document.ERP.BillOfMaterials.Documents.BOMNavigation")]
	public class MDBOMNavigation : BusinessObject
	{
		public MDBOMNavigation(System.IntPtr wrappedObject) : base(wrappedObject)
		{
			DocumentController.controller = new Microarea.EasyBuilder.MVC.DocumentController(this);
			this.CallCreateComponents();
		}

		public static MDBOMNavigation Create()
		{
			return MDBOMNavigation.Create<MDBOMNavigation>("Document.ERP.BillOfMaterials.Documents.BOMNavigation");
		}

		public static MDBOMNavigation Create(Microarea.Framework.TBApplicationWrapper.DocumentContext context)
		{
			return MDBOMNavigation.Create<MDBOMNavigation>("Document.ERP.BillOfMaterials.Documents.BOMNavigation", context);
		}

		public static MDBOMNavigation CreateUnattended(Microarea.Framework.TBApplicationWrapper.DocumentContext context)
		{
			return MDBOMNavigation.CreateUnattended<MDBOMNavigation>("Document.ERP.BillOfMaterials.Documents.BOMNavigation", context);
		}

		public static MDBOMNavigation CreateHidden(Microarea.Framework.TBApplicationWrapper.DocumentContext context)
		{
			return MDBOMNavigation.CreateHidden<MDBOMNavigation>("Document.ERP.BillOfMaterials.Documents.BOMNavigation", context);
		}

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_sItemBOMHKLSelector;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld__DEBUG;

		public Microarea.Framework.TBApplicationWrapper.MDataInt fld_FormMode;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_HeaderTitle;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_HeaderSubTitle;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_FiltersPanelText;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_ActionsPanelText;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_FooterPanelText;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bFiltersPanelCollapsedStatus;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bActionsPanelCollapsedStatus;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bFooterPanelCollapsedStatus;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_Title;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bWeightedAverage;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bAllocationManage;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bYearOrStorageNode;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bYearNode;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bNoYearNode;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bYearOrStorageNodeAndWeightedAverage;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bYearOrStorageNodeAndNotWeightedAverage;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_CustomDescription1;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_CustomDescription2;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_CustomDescription3;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_CustomDescription4;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_CustomDescription5;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bCustomDescription1Compiled;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bCustomDescription2Compiled;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bCustomDescription3Compiled;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bCustomDescription4Compiled;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bCustomDescription5Compiled;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_LastCost;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_AverageCost;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_WeightedAverage;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_InitialBookInv;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_InitialBookInvValue;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_FinalBookInventory;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_BookInvValue;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_InitialOnHand;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_FinalOnHand;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_OrderedPurchOrd;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_OrderedToProd;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_ReservedSaleOrd;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_AllocatedQty;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_ReservedByProd;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_Availability;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_PurchasesQty;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_PurchasesValue;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_ReceivedQty;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_ReceivedValue;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_SalesQty;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_SalesValue;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_ScrapQty;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_ScrapValue;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_IssuedQty;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_IssuedValue;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_CIGValue;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_InitialReturnedQty;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_ReturnedQty;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_InitialForRepairing;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_ForRepairing;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_InitialSampleGoods;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_SampleGoods;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_InitialSampling;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_Sampling;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_InitialBailment;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_Bailment;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_PickedQty;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_ProducedQty;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_ProducedValue;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_InitialUsedByProduction;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_InitialUsedInProductionValue;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_UsedInProduction;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_PickingValue;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_UsedInProductionValue;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_InitialSubcontracting;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_Subcontracting;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_InitialForSubcontracting;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_ForSubcontracting;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_InitialCustomQty1;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_InitialCustomValue1;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_CustomQty1;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_CustomValue1;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_InitialCustomQty2;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_InitialCustomValue2;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_CustomQty2;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_CustomValue2;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_InitialCustomQty3;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_InitialCustomValue3;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_CustomQty3;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_CustomValue3;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_InitialCustomQty4;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_InitialCustomValue4;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_CustomQty4;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_CustomValue4;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_InitialCustomQty5;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_InitialCustomValue5;

		public Microarea.Framework.TBApplicationWrapper.MDataQty fld_CustomQty5;

		public Microarea.Framework.TBApplicationWrapper.MDataMon fld_CustomValue5;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_FindComponent;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_ECORevision;

		public Microarea.Framework.TBApplicationWrapper.MDataDate fld_DateValid;

		public Microarea.Framework.TBApplicationWrapper.MDataInt fld_NrLevels;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_BOM;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_Variant;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bUseVariants;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bAlsoRouting;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bUseToolsManagement;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bAlsoTools;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bUseMultiStepRouting;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bAlsoLabour;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bAlsoNotes;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bAlsoReference;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bAlsoDisabledBOM;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bEasyAttachmentEnable;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bAlsoAttachments;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bUseECO;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bApplyECO;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bExplodeAll;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bCalledIsGroup;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bCalledBOMIsNote;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bCalledBOMIsReference;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bCalledIsRouting;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bCalledIsBOM;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bCalledIsComponent;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bCalledIsAttachment;

		public Microarea.Framework.TBApplicationWrapper.MDataDate fld_ECODate;

		public Microarea.Framework.TBApplicationWrapper.MDataInt fld_ItemMaxLen;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bShowScrapPercentage;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bUseScrapPercentage;

		public Microarea.Framework.TBApplicationWrapper.MDataBool fld_bEnableDockPanel;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_sTextDisable;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_sHintDisable;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_sHintExplode;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_sFilterOpenBOM;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_sBtnNavigation;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_sFilterBOM;

		public Microarea.Framework.TBApplicationWrapper.MDataStr fld_HeaderStripTitle;

		public Microarea.Framework.TBApplicationWrapper.MDataInt fld_MoneyDecimal;

		public Microarea.Framework.TBApplicationWrapper.MDataInt fld_NAMoneyDecimal;

		public override void CreateComponents()
		{
			this.fld_sItemBOMHKLSelector = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("sItemBOMHKLSelector"));
			this.fld__DEBUG = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("_DEBUG"));
			this.fld_FormMode = new Microarea.Framework.TBApplicationWrapper.MDataInt(this.GetFieldPtr("FormMode"));
			this.fld_HeaderTitle = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("HeaderTitle"));
			this.fld_HeaderSubTitle = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("HeaderSubTitle"));
			this.fld_FiltersPanelText = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("FiltersPanelText"));
			this.fld_ActionsPanelText = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("ActionsPanelText"));
			this.fld_FooterPanelText = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("FooterPanelText"));
			this.fld_bFiltersPanelCollapsedStatus = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bFiltersPanelCollapsedStatus"));
			this.fld_bActionsPanelCollapsedStatus = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bActionsPanelCollapsedStatus"));
			this.fld_bFooterPanelCollapsedStatus = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bFooterPanelCollapsedStatus"));
			this.fld_Title = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Title"));
			this.fld_bWeightedAverage = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bWeightedAverage"));
			this.fld_bAllocationManage = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bAllocationManage"));
			this.fld_bYearOrStorageNode = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bYearOrStorageNode"));
			this.fld_bYearNode = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bYearNode"));
			this.fld_bNoYearNode = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bNoYearNode"));
			this.fld_bYearOrStorageNodeAndWeightedAverage = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bYearOrStorageNodeAndWeightedAverage"));
			this.fld_bYearOrStorageNodeAndNotWeightedAverage = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bYearOrStorageNodeAndNotWeightedAverage"));
			this.fld_CustomDescription1 = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CustomDescription1"));
			this.fld_CustomDescription2 = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CustomDescription2"));
			this.fld_CustomDescription3 = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CustomDescription3"));
			this.fld_CustomDescription4 = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CustomDescription4"));
			this.fld_CustomDescription5 = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("CustomDescription5"));
			this.fld_bCustomDescription1Compiled = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bCustomDescription1Compiled"));
			this.fld_bCustomDescription2Compiled = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bCustomDescription2Compiled"));
			this.fld_bCustomDescription3Compiled = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bCustomDescription3Compiled"));
			this.fld_bCustomDescription4Compiled = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bCustomDescription4Compiled"));
			this.fld_bCustomDescription5Compiled = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bCustomDescription5Compiled"));
			this.fld_LastCost = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("LastCost"));
			this.fld_AverageCost = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("AverageCost"));
			this.fld_WeightedAverage = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("WeightedAverage"));
			this.fld_InitialBookInv = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("InitialBookInv"));
			this.fld_InitialBookInvValue = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("InitialBookInvValue"));
			this.fld_FinalBookInventory = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("FinalBookInventory"));
			this.fld_BookInvValue = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("BookInvValue"));
			this.fld_InitialOnHand = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("InitialOnHand"));
			this.fld_FinalOnHand = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("FinalOnHand"));
			this.fld_OrderedPurchOrd = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("OrderedPurchOrd"));
			this.fld_OrderedToProd = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("OrderedToProd"));
			this.fld_ReservedSaleOrd = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("ReservedSaleOrd"));
			this.fld_AllocatedQty = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("AllocatedQty"));
			this.fld_ReservedByProd = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("ReservedByProd"));
			this.fld_Availability = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("Availability"));
			this.fld_PurchasesQty = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("PurchasesQty"));
			this.fld_PurchasesValue = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("PurchasesValue"));
			this.fld_ReceivedQty = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("ReceivedQty"));
			this.fld_ReceivedValue = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("ReceivedValue"));
			this.fld_SalesQty = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("SalesQty"));
			this.fld_SalesValue = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("SalesValue"));
			this.fld_ScrapQty = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("ScrapQty"));
			this.fld_ScrapValue = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("ScrapValue"));
			this.fld_IssuedQty = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("IssuedQty"));
			this.fld_IssuedValue = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("IssuedValue"));
			this.fld_CIGValue = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("CIGValue"));
			this.fld_InitialReturnedQty = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("InitialReturnedQty"));
			this.fld_ReturnedQty = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("ReturnedQty"));
			this.fld_InitialForRepairing = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("InitialForRepairing"));
			this.fld_ForRepairing = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("ForRepairing"));
			this.fld_InitialSampleGoods = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("InitialSampleGoods"));
			this.fld_SampleGoods = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("SampleGoods"));
			this.fld_InitialSampling = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("InitialSampling"));
			this.fld_Sampling = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("Sampling"));
			this.fld_InitialBailment = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("InitialBailment"));
			this.fld_Bailment = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("Bailment"));
			this.fld_PickedQty = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("PickedQty"));
			this.fld_ProducedQty = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("ProducedQty"));
			this.fld_ProducedValue = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("ProducedValue"));
			this.fld_InitialUsedByProduction = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("InitialUsedByProduction"));
			this.fld_InitialUsedInProductionValue = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("InitialUsedInProductionValue"));
			this.fld_UsedInProduction = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("UsedInProduction"));
			this.fld_PickingValue = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("PickingValue"));
			this.fld_UsedInProductionValue = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("UsedInProductionValue"));
			this.fld_InitialSubcontracting = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("InitialSubcontracting"));
			this.fld_Subcontracting = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("Subcontracting"));
			this.fld_InitialForSubcontracting = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("InitialForSubcontracting"));
			this.fld_ForSubcontracting = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("ForSubcontracting"));
			this.fld_InitialCustomQty1 = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("InitialCustomQty1"));
			this.fld_InitialCustomValue1 = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("InitialCustomValue1"));
			this.fld_CustomQty1 = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("CustomQty1"));
			this.fld_CustomValue1 = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("CustomValue1"));
			this.fld_InitialCustomQty2 = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("InitialCustomQty2"));
			this.fld_InitialCustomValue2 = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("InitialCustomValue2"));
			this.fld_CustomQty2 = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("CustomQty2"));
			this.fld_CustomValue2 = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("CustomValue2"));
			this.fld_InitialCustomQty3 = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("InitialCustomQty3"));
			this.fld_InitialCustomValue3 = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("InitialCustomValue3"));
			this.fld_CustomQty3 = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("CustomQty3"));
			this.fld_CustomValue3 = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("CustomValue3"));
			this.fld_InitialCustomQty4 = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("InitialCustomQty4"));
			this.fld_InitialCustomValue4 = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("InitialCustomValue4"));
			this.fld_CustomQty4 = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("CustomQty4"));
			this.fld_CustomValue4 = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("CustomValue4"));
			this.fld_InitialCustomQty5 = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("InitialCustomQty5"));
			this.fld_InitialCustomValue5 = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("InitialCustomValue5"));
			this.fld_CustomQty5 = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("CustomQty5"));
			this.fld_CustomValue5 = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("CustomValue5"));
			this.fld_FindComponent = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("FindComponent"));
			this.fld_ECORevision = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("ECORevision"));
			this.fld_DateValid = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("DateValid"));
			this.fld_NrLevels = new Microarea.Framework.TBApplicationWrapper.MDataInt(this.GetFieldPtr("NrLevels"));
			this.fld_BOM = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("BOM"));
			this.fld_Variant = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Variant"));
			this.fld_bUseVariants = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bUseVariants"));
			this.fld_bAlsoRouting = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bAlsoRouting"));
			this.fld_bUseToolsManagement = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bUseToolsManagement"));
			this.fld_bAlsoTools = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bAlsoTools"));
			this.fld_bUseMultiStepRouting = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bUseMultiStepRouting"));
			this.fld_bAlsoLabour = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bAlsoLabour"));
			this.fld_bAlsoNotes = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bAlsoNotes"));
			this.fld_bAlsoReference = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bAlsoReference"));
			this.fld_bAlsoDisabledBOM = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bAlsoDisabledBOM"));
			this.fld_bEasyAttachmentEnable = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bEasyAttachmentEnable"));
			this.fld_bAlsoAttachments = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bAlsoAttachments"));
			this.fld_bUseECO = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bUseECO"));
			this.fld_bApplyECO = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bApplyECO"));
			this.fld_bExplodeAll = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bExplodeAll"));
			this.fld_bCalledIsGroup = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bCalledIsGroup"));
			this.fld_bCalledBOMIsNote = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bCalledBOMIsNote"));
			this.fld_bCalledBOMIsReference = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bCalledBOMIsReference"));
			this.fld_bCalledIsRouting = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bCalledIsRouting"));
			this.fld_bCalledIsBOM = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bCalledIsBOM"));
			this.fld_bCalledIsComponent = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bCalledIsComponent"));
			this.fld_bCalledIsAttachment = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bCalledIsAttachment"));
			this.fld_ECODate = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("ECODate"));
			this.fld_ItemMaxLen = new Microarea.Framework.TBApplicationWrapper.MDataInt(this.GetFieldPtr("ItemMaxLen"));
			this.fld_bShowScrapPercentage = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bShowScrapPercentage"));
			this.fld_bUseScrapPercentage = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bUseScrapPercentage"));
			this.fld_bEnableDockPanel = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("bEnableDockPanel"));
			this.fld_sTextDisable = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("sTextDisable"));
			this.fld_sHintDisable = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("sHintDisable"));
			this.fld_sHintExplode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("sHintExplode"));
			this.fld_sFilterOpenBOM = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("sFilterOpenBOM"));
			this.fld_sBtnNavigation = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("sBtnNavigation"));
			this.fld_sFilterBOM = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("sFilterBOM"));
			this.fld_HeaderStripTitle = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("HeaderStripTitle"));
			this.fld_MoneyDecimal = new Microarea.Framework.TBApplicationWrapper.MDataInt(this.GetFieldPtr("MoneyDecimal"));
			this.fld_NAMoneyDecimal = new Microarea.Framework.TBApplicationWrapper.MDataInt(this.GetFieldPtr("NAMoneyDecimal"));
		}

		public override void ApplyResources()
		{
			Microarea.EasyBuilder.CustomizationComponentResourceManager resources = Strings.ResourceManager;
		}

		public override void ClearComponents()
		{
			base.ClearComponents();
			fld_sItemBOMHKLSelector = null;
			fld__DEBUG = null;
			fld_FormMode = null;
			fld_HeaderTitle = null;
			fld_HeaderSubTitle = null;
			fld_FiltersPanelText = null;
			fld_ActionsPanelText = null;
			fld_FooterPanelText = null;
			fld_bFiltersPanelCollapsedStatus = null;
			fld_bActionsPanelCollapsedStatus = null;
			fld_bFooterPanelCollapsedStatus = null;
			fld_Title = null;
			fld_bWeightedAverage = null;
			fld_bAllocationManage = null;
			fld_bYearOrStorageNode = null;
			fld_bYearNode = null;
			fld_bNoYearNode = null;
			fld_bYearOrStorageNodeAndWeightedAverage = null;
			fld_bYearOrStorageNodeAndNotWeightedAverage = null;
			fld_CustomDescription1 = null;
			fld_CustomDescription2 = null;
			fld_CustomDescription3 = null;
			fld_CustomDescription4 = null;
			fld_CustomDescription5 = null;
			fld_bCustomDescription1Compiled = null;
			fld_bCustomDescription2Compiled = null;
			fld_bCustomDescription3Compiled = null;
			fld_bCustomDescription4Compiled = null;
			fld_bCustomDescription5Compiled = null;
			fld_LastCost = null;
			fld_AverageCost = null;
			fld_WeightedAverage = null;
			fld_InitialBookInv = null;
			fld_InitialBookInvValue = null;
			fld_FinalBookInventory = null;
			fld_BookInvValue = null;
			fld_InitialOnHand = null;
			fld_FinalOnHand = null;
			fld_OrderedPurchOrd = null;
			fld_OrderedToProd = null;
			fld_ReservedSaleOrd = null;
			fld_AllocatedQty = null;
			fld_ReservedByProd = null;
			fld_Availability = null;
			fld_PurchasesQty = null;
			fld_PurchasesValue = null;
			fld_ReceivedQty = null;
			fld_ReceivedValue = null;
			fld_SalesQty = null;
			fld_SalesValue = null;
			fld_ScrapQty = null;
			fld_ScrapValue = null;
			fld_IssuedQty = null;
			fld_IssuedValue = null;
			fld_CIGValue = null;
			fld_InitialReturnedQty = null;
			fld_ReturnedQty = null;
			fld_InitialForRepairing = null;
			fld_ForRepairing = null;
			fld_InitialSampleGoods = null;
			fld_SampleGoods = null;
			fld_InitialSampling = null;
			fld_Sampling = null;
			fld_InitialBailment = null;
			fld_Bailment = null;
			fld_PickedQty = null;
			fld_ProducedQty = null;
			fld_ProducedValue = null;
			fld_InitialUsedByProduction = null;
			fld_InitialUsedInProductionValue = null;
			fld_UsedInProduction = null;
			fld_PickingValue = null;
			fld_UsedInProductionValue = null;
			fld_InitialSubcontracting = null;
			fld_Subcontracting = null;
			fld_InitialForSubcontracting = null;
			fld_ForSubcontracting = null;
			fld_InitialCustomQty1 = null;
			fld_InitialCustomValue1 = null;
			fld_CustomQty1 = null;
			fld_CustomValue1 = null;
			fld_InitialCustomQty2 = null;
			fld_InitialCustomValue2 = null;
			fld_CustomQty2 = null;
			fld_CustomValue2 = null;
			fld_InitialCustomQty3 = null;
			fld_InitialCustomValue3 = null;
			fld_CustomQty3 = null;
			fld_CustomValue3 = null;
			fld_InitialCustomQty4 = null;
			fld_InitialCustomValue4 = null;
			fld_CustomQty4 = null;
			fld_CustomValue4 = null;
			fld_InitialCustomQty5 = null;
			fld_InitialCustomValue5 = null;
			fld_CustomQty5 = null;
			fld_CustomValue5 = null;
			fld_FindComponent = null;
			fld_ECORevision = null;
			fld_DateValid = null;
			fld_NrLevels = null;
			fld_BOM = null;
			fld_Variant = null;
			fld_bUseVariants = null;
			fld_bAlsoRouting = null;
			fld_bUseToolsManagement = null;
			fld_bAlsoTools = null;
			fld_bUseMultiStepRouting = null;
			fld_bAlsoLabour = null;
			fld_bAlsoNotes = null;
			fld_bAlsoReference = null;
			fld_bAlsoDisabledBOM = null;
			fld_bEasyAttachmentEnable = null;
			fld_bAlsoAttachments = null;
			fld_bUseECO = null;
			fld_bApplyECO = null;
			fld_bExplodeAll = null;
			fld_bCalledIsGroup = null;
			fld_bCalledBOMIsNote = null;
			fld_bCalledBOMIsReference = null;
			fld_bCalledIsRouting = null;
			fld_bCalledIsBOM = null;
			fld_bCalledIsComponent = null;
			fld_bCalledIsAttachment = null;
			fld_ECODate = null;
			fld_ItemMaxLen = null;
			fld_bShowScrapPercentage = null;
			fld_bUseScrapPercentage = null;
			fld_bEnableDockPanel = null;
			fld_sTextDisable = null;
			fld_sHintDisable = null;
			fld_sHintExplode = null;
			fld_sFilterOpenBOM = null;
			fld_sBtnNavigation = null;
			fld_sFilterBOM = null;
			fld_HeaderStripTitle = null;
			fld_MoneyDecimal = null;
			fld_NAMoneyDecimal = null;
		}
	}
}

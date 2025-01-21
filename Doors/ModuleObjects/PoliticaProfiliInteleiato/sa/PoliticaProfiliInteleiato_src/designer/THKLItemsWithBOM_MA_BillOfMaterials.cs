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
namespace Customization.Doors.Doors.DynamicDocuments.PoliticaProfiliInteleiato.PoliticaProfiliInteleiato
{
	public class THKLItemsWithBOM_MA_BillOfMaterials : Microarea.Framework.TBApplicationWrapper.MSqlRecord
	{
		public THKLItemsWithBOM_MA_BillOfMaterials(System.IntPtr wrappedObject) : base(wrappedObject)
		{
		}

		public MDataStr fld_BOM;

		public MDataEnum fld_CodeType;

		public MDataStr fld_Description;

		public MDataStr fld_UoM;

		public MDataDate fld_CreationDate;

		public MDataDate fld_LastModificationDate;

		public MDataBool fld_UsePercQty;

		public MDataBool fld_SF;

		public MDataStr fld_Notes;

		public MDataBool fld_InProduction;

		public MDataLng fld_LastSubId;

		public MDataBool fld_Configurable;

		public MDataBool fld_Disabled;

		public MDataBool fld_SalesDocOnly;

		public MDataBool fld_IsFoodRecipe;

		public MDataDate fld_TBCreated;

		public MDataDate fld_TBModified;

		public MDataLng fld_TBCreatedID;

		public MDataLng fld_TBModifiedID;

		public MDataGuid fld_TBGuid;

		public MDataStr fld_MA_Items_Item;

		public MDataStr fld_MA_Items_SaleBarCode;

		public MDataStr fld_MA_Items_Description;

		public MDataBool fld_MA_Items_IsGood;

		public MDataStr fld_MA_Items_TaxCode;

		public MDataStr fld_MA_Items_BaseUoM;

		public MDataMon fld_MA_Items_BasePrice;

		public MDataPerc fld_MA_Items_Discount1;

		public MDataPerc fld_MA_Items_Discount2;

		public MDataStr fld_MA_Items_DiscountFormula;

		public MDataPerc fld_MA_Items_Markup;

		public MDataStr fld_MA_Items_ItemType;

		public MDataStr fld_MA_Items_CommodityCtg;

		public MDataStr fld_MA_Items_HomogeneousCtg;

		public MDataStr fld_MA_Items_CommissionCtg;

		public MDataStr fld_MA_Items_SaleOffset;

		public MDataStr fld_MA_Items_PurchaseOffset;

		public MDataDate fld_MA_Items_AvailabilityDate;

		public MDataEnum fld_MA_Items_SaleType;

		public MDataBool fld_MA_Items_HasCustomers;

		public MDataBool fld_MA_Items_HasSuppliers;

		public MDataStr fld_MA_Items_InternalNote;

		public MDataStr fld_MA_Items_PublicNote;

		public MDataStr fld_MA_Items_Producer;

		public MDataBool fld_MA_Items_UseSerialNo;

		public MDataStr fld_MA_Items_OldItem;

		public MDataBool fld_MA_Items_Disabled;

		public MDataStr fld_MA_Items_ProductCtg;

		public MDataStr fld_MA_Items_ProductSubCtg;

		public MDataBool fld_MA_Items_KitExpansion;

		public MDataBool fld_MA_Items_PostKitComponents;

		public MDataStr fld_MA_Items_Picture;

		public MDataDate fld_MA_Items_StandardCostDate;

		public MDataEnum fld_MA_Items_Nature;

		public MDataStr fld_MA_Items_SecondRateUoM;

		public MDataStr fld_MA_Items_SecondRate;

		public MDataEnum fld_MA_Items_PurchaseType;

		public MDataStr fld_MA_Items_ConsuptionOffset;

		public MDataBool fld_MA_Items_NotPostable;

		public MDataPerc fld_MA_Items_SalespersonComm;

		public MDataStr fld_MA_Items_CostCenter;

		public MDataBool fld_MA_Items_NoUoMSearch;

		public MDataStr fld_MA_Items_Job;

		public MDataStr fld_MA_Items_DescriptionText;

		public MDataBool fld_MA_Items_CanBeDisabled;

		public MDataStr fld_MA_Items_ProductLine;

		public MDataStr fld_MA_Items_ShortDescription;

		public MDataBool fld_MA_Items_BasePriceWithTax;

		public MDataBool fld_MA_Items_SubjectToWithholdingTax;

		public MDataDate fld_MA_Items_CreationDate;

		public MDataDate fld_MA_Items_ModificationDate;

		public MDataBool fld_MA_Items_NoAddDiscountInSaleDoc;

		public MDataStr fld_MA_Items_BarcodeSegment;

		public MDataBool fld_MA_Items_ReverseCharge;

		public MDataStr fld_MA_Items_RCTaxCode;

		public MDataBool fld_MA_Items_Draft;

		public MDataBool fld_MA_Items_Valorize;

		public MDataStr fld_MA_Items_FiscalUoM;

		public MDataStr fld_MA_Items_AccountingType;

		public MDataStr fld_MA_Items_AccountingRuleCode;

		public MDataBool fld_MA_Items_NoPaymDiscountInDoc;

		public MDataBool fld_MA_Items_ToBeDiscontinued;

		public MDataLng fld_MA_Items_LastSubIdNotes;

		public MDataBool fld_l_NoBOM;

		public MDataQty fld_l_OnHand;

		public MDataQty fld_l_BookInventory;

		public MDataBool fld_MA_Items_AdditionalCharge;

		public MDataStr fld_MA_Items_ISBN;

		public MDataStr fld_MA_Items_AuthorCode;

		public MDataMon fld_MA_Items_CoverPrice;

		public MDataStr fld_MA_Items_EITypeCode;

		public MDataStr fld_MA_Items_EIValueCode;

		public MDataEnum fld_MA_Items_EITypeLine;

		public MDataStr fld_MA_Items_AswAddChargeCode;

		public MDataStr fld_MA_Items_GroupItemCode;

		public MDataDate fld_MA_Items_TBCreated;

		public MDataDate fld_MA_Items_TBModified;

		public MDataLng fld_MA_Items_TBCreatedID;

		public MDataLng fld_MA_Items_TBModifiedID;

		public MDataGuid fld_MA_Items_TBGuid;

		public MDataStr fld_MA_Items_DoorsApertura;

		public MDataStr fld_MA_Items_DoorsNote;

		public MDataDbl fld_MA_Items_DoorsLarghezza;

		public MDataDbl fld_MA_Items_DoorsAltezza;

		public MDataStr fld_MA_Items_DoorsFinitura;

		public MDataStr fld_MA_Items_DoorsBattuta;

		public MDataStr fld_MA_Items_DoorsTipoTelaio;

		public MDataDbl fld_MA_Items_DoorsSpessore;

		public MDataDbl fld_MA_Items_DoorsLarghezzaIntBatt;

		public MDataDbl fld_MA_Items_DoorsAltezzaIntBatt;

		public MDataDbl fld_MA_Items_DoorsAriaL;

		public MDataDbl fld_MA_Items_DoorsAriaH;

		public MDataDbl fld_MA_Items_DoorsSpProfIntTelaio;

		public MDataDbl fld_MA_Items_DoorsSpProfEstTelaio;

		public override void CreateComponents()
		{
			fld_BOM = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("BOM"));
			this.Add(fld_BOM, false);
			fld_CodeType = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("CodeType"));
			this.Add(fld_CodeType, false);
			fld_Description = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Description"));
			this.Add(fld_Description, false);
			fld_UoM = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("UoM"));
			this.Add(fld_UoM, false);
			fld_CreationDate = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("CreationDate"));
			this.Add(fld_CreationDate, false);
			fld_LastModificationDate = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("LastModificationDate"));
			this.Add(fld_LastModificationDate, false);
			fld_UsePercQty = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("UsePercQty"));
			this.Add(fld_UsePercQty, false);
			fld_SF = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("SF"));
			this.Add(fld_SF, false);
			fld_Notes = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("Notes"));
			this.Add(fld_Notes, false);
			fld_InProduction = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("InProduction"));
			this.Add(fld_InProduction, false);
			fld_LastSubId = new Microarea.Framework.TBApplicationWrapper.MDataLng(this.GetFieldPtr("LastSubId"));
			this.Add(fld_LastSubId, false);
			fld_Configurable = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("Configurable"));
			this.Add(fld_Configurable, false);
			fld_Disabled = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("Disabled"));
			this.Add(fld_Disabled, false);
			fld_SalesDocOnly = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("SalesDocOnly"));
			this.Add(fld_SalesDocOnly, false);
			fld_IsFoodRecipe = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("IsFoodRecipe"));
			this.Add(fld_IsFoodRecipe, false);
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
			fld_MA_Items_Item = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.Item"));
			this.Add(fld_MA_Items_Item, false);
			fld_MA_Items_SaleBarCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.SaleBarCode"));
			this.Add(fld_MA_Items_SaleBarCode, false);
			fld_MA_Items_Description = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.Description"));
			this.Add(fld_MA_Items_Description, false);
			fld_MA_Items_IsGood = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("MA_Items.IsGood"));
			this.Add(fld_MA_Items_IsGood, false);
			fld_MA_Items_TaxCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.TaxCode"));
			this.Add(fld_MA_Items_TaxCode, false);
			fld_MA_Items_BaseUoM = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.BaseUoM"));
			this.Add(fld_MA_Items_BaseUoM, false);
			fld_MA_Items_BasePrice = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("MA_Items.BasePrice"));
			this.Add(fld_MA_Items_BasePrice, false);
			fld_MA_Items_Discount1 = new Microarea.Framework.TBApplicationWrapper.MDataPerc(this.GetFieldPtr("MA_Items.Discount1"));
			this.Add(fld_MA_Items_Discount1, false);
			fld_MA_Items_Discount2 = new Microarea.Framework.TBApplicationWrapper.MDataPerc(this.GetFieldPtr("MA_Items.Discount2"));
			this.Add(fld_MA_Items_Discount2, false);
			fld_MA_Items_DiscountFormula = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.DiscountFormula"));
			this.Add(fld_MA_Items_DiscountFormula, false);
			fld_MA_Items_Markup = new Microarea.Framework.TBApplicationWrapper.MDataPerc(this.GetFieldPtr("MA_Items.Markup"));
			this.Add(fld_MA_Items_Markup, false);
			fld_MA_Items_ItemType = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.ItemType"));
			this.Add(fld_MA_Items_ItemType, false);
			fld_MA_Items_CommodityCtg = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.CommodityCtg"));
			this.Add(fld_MA_Items_CommodityCtg, false);
			fld_MA_Items_HomogeneousCtg = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.HomogeneousCtg"));
			this.Add(fld_MA_Items_HomogeneousCtg, false);
			fld_MA_Items_CommissionCtg = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.CommissionCtg"));
			this.Add(fld_MA_Items_CommissionCtg, false);
			fld_MA_Items_SaleOffset = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.SaleOffset"));
			this.Add(fld_MA_Items_SaleOffset, false);
			fld_MA_Items_PurchaseOffset = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.PurchaseOffset"));
			this.Add(fld_MA_Items_PurchaseOffset, false);
			fld_MA_Items_AvailabilityDate = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("MA_Items.AvailabilityDate"));
			this.Add(fld_MA_Items_AvailabilityDate, false);
			fld_MA_Items_SaleType = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("MA_Items.SaleType"));
			this.Add(fld_MA_Items_SaleType, false);
			fld_MA_Items_HasCustomers = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("MA_Items.HasCustomers"));
			this.Add(fld_MA_Items_HasCustomers, false);
			fld_MA_Items_HasSuppliers = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("MA_Items.HasSuppliers"));
			this.Add(fld_MA_Items_HasSuppliers, false);
			fld_MA_Items_InternalNote = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.InternalNote"));
			this.Add(fld_MA_Items_InternalNote, false);
			fld_MA_Items_PublicNote = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.PublicNote"));
			this.Add(fld_MA_Items_PublicNote, false);
			fld_MA_Items_Producer = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.Producer"));
			this.Add(fld_MA_Items_Producer, false);
			fld_MA_Items_UseSerialNo = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("MA_Items.UseSerialNo"));
			this.Add(fld_MA_Items_UseSerialNo, false);
			fld_MA_Items_OldItem = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.OldItem"));
			this.Add(fld_MA_Items_OldItem, false);
			fld_MA_Items_Disabled = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("MA_Items.Disabled"));
			this.Add(fld_MA_Items_Disabled, false);
			fld_MA_Items_ProductCtg = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.ProductCtg"));
			this.Add(fld_MA_Items_ProductCtg, false);
			fld_MA_Items_ProductSubCtg = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.ProductSubCtg"));
			this.Add(fld_MA_Items_ProductSubCtg, false);
			fld_MA_Items_KitExpansion = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("MA_Items.KitExpansion"));
			this.Add(fld_MA_Items_KitExpansion, false);
			fld_MA_Items_PostKitComponents = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("MA_Items.PostKitComponents"));
			this.Add(fld_MA_Items_PostKitComponents, false);
			fld_MA_Items_Picture = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.Picture"));
			this.Add(fld_MA_Items_Picture, false);
			fld_MA_Items_StandardCostDate = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("MA_Items.StandardCostDate"));
			this.Add(fld_MA_Items_StandardCostDate, false);
			fld_MA_Items_Nature = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("MA_Items.Nature"));
			this.Add(fld_MA_Items_Nature, false);
			fld_MA_Items_SecondRateUoM = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.SecondRateUoM"));
			this.Add(fld_MA_Items_SecondRateUoM, false);
			fld_MA_Items_SecondRate = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.SecondRate"));
			this.Add(fld_MA_Items_SecondRate, false);
			fld_MA_Items_PurchaseType = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("MA_Items.PurchaseType"));
			this.Add(fld_MA_Items_PurchaseType, false);
			fld_MA_Items_ConsuptionOffset = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.ConsuptionOffset"));
			this.Add(fld_MA_Items_ConsuptionOffset, false);
			fld_MA_Items_NotPostable = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("MA_Items.NotPostable"));
			this.Add(fld_MA_Items_NotPostable, false);
			fld_MA_Items_SalespersonComm = new Microarea.Framework.TBApplicationWrapper.MDataPerc(this.GetFieldPtr("MA_Items.SalespersonComm"));
			this.Add(fld_MA_Items_SalespersonComm, false);
			fld_MA_Items_CostCenter = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.CostCenter"));
			this.Add(fld_MA_Items_CostCenter, false);
			fld_MA_Items_NoUoMSearch = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("MA_Items.NoUoMSearch"));
			this.Add(fld_MA_Items_NoUoMSearch, false);
			fld_MA_Items_Job = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.Job"));
			this.Add(fld_MA_Items_Job, false);
			fld_MA_Items_DescriptionText = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.DescriptionText"));
			this.Add(fld_MA_Items_DescriptionText, false);
			fld_MA_Items_CanBeDisabled = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("MA_Items.CanBeDisabled"));
			this.Add(fld_MA_Items_CanBeDisabled, false);
			fld_MA_Items_ProductLine = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.ProductLine"));
			this.Add(fld_MA_Items_ProductLine, false);
			fld_MA_Items_ShortDescription = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.ShortDescription"));
			this.Add(fld_MA_Items_ShortDescription, false);
			fld_MA_Items_BasePriceWithTax = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("MA_Items.BasePriceWithTax"));
			this.Add(fld_MA_Items_BasePriceWithTax, false);
			fld_MA_Items_SubjectToWithholdingTax = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("MA_Items.SubjectToWithholdingTax"));
			this.Add(fld_MA_Items_SubjectToWithholdingTax, false);
			fld_MA_Items_CreationDate = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("MA_Items.CreationDate"));
			this.Add(fld_MA_Items_CreationDate, false);
			fld_MA_Items_ModificationDate = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("MA_Items.ModificationDate"));
			this.Add(fld_MA_Items_ModificationDate, false);
			fld_MA_Items_NoAddDiscountInSaleDoc = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("MA_Items.NoAddDiscountInSaleDoc"));
			this.Add(fld_MA_Items_NoAddDiscountInSaleDoc, false);
			fld_MA_Items_BarcodeSegment = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.BarcodeSegment"));
			this.Add(fld_MA_Items_BarcodeSegment, false);
			fld_MA_Items_ReverseCharge = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("MA_Items.ReverseCharge"));
			this.Add(fld_MA_Items_ReverseCharge, false);
			fld_MA_Items_RCTaxCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.RCTaxCode"));
			this.Add(fld_MA_Items_RCTaxCode, false);
			fld_MA_Items_Draft = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("MA_Items.Draft"));
			this.Add(fld_MA_Items_Draft, false);
			fld_MA_Items_Valorize = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("MA_Items.Valorize"));
			this.Add(fld_MA_Items_Valorize, false);
			fld_MA_Items_FiscalUoM = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.FiscalUoM"));
			this.Add(fld_MA_Items_FiscalUoM, false);
			fld_MA_Items_AccountingType = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.AccountingType"));
			this.Add(fld_MA_Items_AccountingType, false);
			fld_MA_Items_AccountingRuleCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.AccountingRuleCode"));
			this.Add(fld_MA_Items_AccountingRuleCode, false);
			fld_MA_Items_NoPaymDiscountInDoc = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("MA_Items.NoPaymDiscountInDoc"));
			this.Add(fld_MA_Items_NoPaymDiscountInDoc, false);
			fld_MA_Items_ToBeDiscontinued = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("MA_Items.ToBeDiscontinued"));
			this.Add(fld_MA_Items_ToBeDiscontinued, false);
			fld_MA_Items_LastSubIdNotes = new Microarea.Framework.TBApplicationWrapper.MDataLng(this.GetFieldPtr("MA_Items.LastSubIdNotes"));
			this.Add(fld_MA_Items_LastSubIdNotes, false);
			fld_l_NoBOM = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("l_NoBOM"));
			this.Add(fld_l_NoBOM, false);
			fld_l_OnHand = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("l_OnHand"));
			this.Add(fld_l_OnHand, false);
			fld_l_BookInventory = new Microarea.Framework.TBApplicationWrapper.MDataQty(this.GetFieldPtr("l_BookInventory"));
			this.Add(fld_l_BookInventory, false);
			fld_MA_Items_AdditionalCharge = new Microarea.Framework.TBApplicationWrapper.MDataBool(this.GetFieldPtr("MA_Items.AdditionalCharge"));
			this.Add(fld_MA_Items_AdditionalCharge, false);
			fld_MA_Items_ISBN = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.ISBN"));
			this.Add(fld_MA_Items_ISBN, false);
			fld_MA_Items_AuthorCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.AuthorCode"));
			this.Add(fld_MA_Items_AuthorCode, false);
			fld_MA_Items_CoverPrice = new Microarea.Framework.TBApplicationWrapper.MDataMon(this.GetFieldPtr("MA_Items.CoverPrice"));
			this.Add(fld_MA_Items_CoverPrice, false);
			fld_MA_Items_EITypeCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.EITypeCode"));
			this.Add(fld_MA_Items_EITypeCode, false);
			fld_MA_Items_EIValueCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.EIValueCode"));
			this.Add(fld_MA_Items_EIValueCode, false);
			fld_MA_Items_EITypeLine = new Microarea.Framework.TBApplicationWrapper.MDataEnum(this.GetFieldPtr("MA_Items.EITypeLine"));
			this.Add(fld_MA_Items_EITypeLine, false);
			fld_MA_Items_AswAddChargeCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.AswAddChargeCode"));
			this.Add(fld_MA_Items_AswAddChargeCode, false);
			fld_MA_Items_GroupItemCode = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.GroupItemCode"));
			this.Add(fld_MA_Items_GroupItemCode, false);
			fld_MA_Items_TBCreated = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("MA_Items.TBCreated"));
			this.Add(fld_MA_Items_TBCreated, false);
			fld_MA_Items_TBModified = new Microarea.Framework.TBApplicationWrapper.MDataDate(this.GetFieldPtr("MA_Items.TBModified"));
			this.Add(fld_MA_Items_TBModified, false);
			fld_MA_Items_TBCreatedID = new Microarea.Framework.TBApplicationWrapper.MDataLng(this.GetFieldPtr("MA_Items.TBCreatedID"));
			this.Add(fld_MA_Items_TBCreatedID, false);
			fld_MA_Items_TBModifiedID = new Microarea.Framework.TBApplicationWrapper.MDataLng(this.GetFieldPtr("MA_Items.TBModifiedID"));
			this.Add(fld_MA_Items_TBModifiedID, false);
			fld_MA_Items_TBGuid = new Microarea.Framework.TBApplicationWrapper.MDataGuid(this.GetFieldPtr("MA_Items.TBGuid"));
			this.Add(fld_MA_Items_TBGuid, false);
			fld_MA_Items_DoorsApertura = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.DoorsApertura"));
			this.Add(fld_MA_Items_DoorsApertura, false);
			fld_MA_Items_DoorsNote = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.DoorsNote"));
			this.Add(fld_MA_Items_DoorsNote, false);
			fld_MA_Items_DoorsLarghezza = new Microarea.Framework.TBApplicationWrapper.MDataDbl(this.GetFieldPtr("MA_Items.DoorsLarghezza"));
			this.Add(fld_MA_Items_DoorsLarghezza, false);
			fld_MA_Items_DoorsAltezza = new Microarea.Framework.TBApplicationWrapper.MDataDbl(this.GetFieldPtr("MA_Items.DoorsAltezza"));
			this.Add(fld_MA_Items_DoorsAltezza, false);
			fld_MA_Items_DoorsFinitura = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.DoorsFinitura"));
			this.Add(fld_MA_Items_DoorsFinitura, false);
			fld_MA_Items_DoorsBattuta = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.DoorsBattuta"));
			this.Add(fld_MA_Items_DoorsBattuta, false);
			fld_MA_Items_DoorsTipoTelaio = new Microarea.Framework.TBApplicationWrapper.MDataStr(this.GetFieldPtr("MA_Items.DoorsTipoTelaio"));
			this.Add(fld_MA_Items_DoorsTipoTelaio, false);
			fld_MA_Items_DoorsSpessore = new Microarea.Framework.TBApplicationWrapper.MDataDbl(this.GetFieldPtr("MA_Items.DoorsSpessore"));
			this.Add(fld_MA_Items_DoorsSpessore, false);
			fld_MA_Items_DoorsLarghezzaIntBatt = new Microarea.Framework.TBApplicationWrapper.MDataDbl(this.GetFieldPtr("MA_Items.DoorsLarghezzaIntBatt"));
			this.Add(fld_MA_Items_DoorsLarghezzaIntBatt, false);
			fld_MA_Items_DoorsAltezzaIntBatt = new Microarea.Framework.TBApplicationWrapper.MDataDbl(this.GetFieldPtr("MA_Items.DoorsAltezzaIntBatt"));
			this.Add(fld_MA_Items_DoorsAltezzaIntBatt, false);
			fld_MA_Items_DoorsAriaL = new Microarea.Framework.TBApplicationWrapper.MDataDbl(this.GetFieldPtr("MA_Items.DoorsAriaL"));
			this.Add(fld_MA_Items_DoorsAriaL, false);
			fld_MA_Items_DoorsAriaH = new Microarea.Framework.TBApplicationWrapper.MDataDbl(this.GetFieldPtr("MA_Items.DoorsAriaH"));
			this.Add(fld_MA_Items_DoorsAriaH, false);
			fld_MA_Items_DoorsSpProfIntTelaio = new Microarea.Framework.TBApplicationWrapper.MDataDbl(this.GetFieldPtr("MA_Items.DoorsSpProfIntTelaio"));
			this.Add(fld_MA_Items_DoorsSpProfIntTelaio, false);
			fld_MA_Items_DoorsSpProfEstTelaio = new Microarea.Framework.TBApplicationWrapper.MDataDbl(this.GetFieldPtr("MA_Items.DoorsSpProfEstTelaio"));
			this.Add(fld_MA_Items_DoorsSpProfEstTelaio, false);
		}

		public override void ApplyResources()
		{
			Microarea.EasyBuilder.CustomizationComponentResourceManager resources = Strings.ResourceManager;
		}

		public override void ClearComponents()
		{
			base.ClearComponents();
			fld_BOM = null;
			fld_CodeType = null;
			fld_Description = null;
			fld_UoM = null;
			fld_CreationDate = null;
			fld_LastModificationDate = null;
			fld_UsePercQty = null;
			fld_SF = null;
			fld_Notes = null;
			fld_InProduction = null;
			fld_LastSubId = null;
			fld_Configurable = null;
			fld_Disabled = null;
			fld_SalesDocOnly = null;
			fld_IsFoodRecipe = null;
			fld_TBCreated = null;
			fld_TBModified = null;
			fld_TBCreatedID = null;
			fld_TBModifiedID = null;
			fld_TBGuid = null;
			fld_MA_Items_Item = null;
			fld_MA_Items_SaleBarCode = null;
			fld_MA_Items_Description = null;
			fld_MA_Items_IsGood = null;
			fld_MA_Items_TaxCode = null;
			fld_MA_Items_BaseUoM = null;
			fld_MA_Items_BasePrice = null;
			fld_MA_Items_Discount1 = null;
			fld_MA_Items_Discount2 = null;
			fld_MA_Items_DiscountFormula = null;
			fld_MA_Items_Markup = null;
			fld_MA_Items_ItemType = null;
			fld_MA_Items_CommodityCtg = null;
			fld_MA_Items_HomogeneousCtg = null;
			fld_MA_Items_CommissionCtg = null;
			fld_MA_Items_SaleOffset = null;
			fld_MA_Items_PurchaseOffset = null;
			fld_MA_Items_AvailabilityDate = null;
			fld_MA_Items_SaleType = null;
			fld_MA_Items_HasCustomers = null;
			fld_MA_Items_HasSuppliers = null;
			fld_MA_Items_InternalNote = null;
			fld_MA_Items_PublicNote = null;
			fld_MA_Items_Producer = null;
			fld_MA_Items_UseSerialNo = null;
			fld_MA_Items_OldItem = null;
			fld_MA_Items_Disabled = null;
			fld_MA_Items_ProductCtg = null;
			fld_MA_Items_ProductSubCtg = null;
			fld_MA_Items_KitExpansion = null;
			fld_MA_Items_PostKitComponents = null;
			fld_MA_Items_Picture = null;
			fld_MA_Items_StandardCostDate = null;
			fld_MA_Items_Nature = null;
			fld_MA_Items_SecondRateUoM = null;
			fld_MA_Items_SecondRate = null;
			fld_MA_Items_PurchaseType = null;
			fld_MA_Items_ConsuptionOffset = null;
			fld_MA_Items_NotPostable = null;
			fld_MA_Items_SalespersonComm = null;
			fld_MA_Items_CostCenter = null;
			fld_MA_Items_NoUoMSearch = null;
			fld_MA_Items_Job = null;
			fld_MA_Items_DescriptionText = null;
			fld_MA_Items_CanBeDisabled = null;
			fld_MA_Items_ProductLine = null;
			fld_MA_Items_ShortDescription = null;
			fld_MA_Items_BasePriceWithTax = null;
			fld_MA_Items_SubjectToWithholdingTax = null;
			fld_MA_Items_CreationDate = null;
			fld_MA_Items_ModificationDate = null;
			fld_MA_Items_NoAddDiscountInSaleDoc = null;
			fld_MA_Items_BarcodeSegment = null;
			fld_MA_Items_ReverseCharge = null;
			fld_MA_Items_RCTaxCode = null;
			fld_MA_Items_Draft = null;
			fld_MA_Items_Valorize = null;
			fld_MA_Items_FiscalUoM = null;
			fld_MA_Items_AccountingType = null;
			fld_MA_Items_AccountingRuleCode = null;
			fld_MA_Items_NoPaymDiscountInDoc = null;
			fld_MA_Items_ToBeDiscontinued = null;
			fld_MA_Items_LastSubIdNotes = null;
			fld_l_NoBOM = null;
			fld_l_OnHand = null;
			fld_l_BookInventory = null;
			fld_MA_Items_AdditionalCharge = null;
			fld_MA_Items_ISBN = null;
			fld_MA_Items_AuthorCode = null;
			fld_MA_Items_CoverPrice = null;
			fld_MA_Items_EITypeCode = null;
			fld_MA_Items_EIValueCode = null;
			fld_MA_Items_EITypeLine = null;
			fld_MA_Items_AswAddChargeCode = null;
			fld_MA_Items_GroupItemCode = null;
			fld_MA_Items_TBCreated = null;
			fld_MA_Items_TBModified = null;
			fld_MA_Items_TBCreatedID = null;
			fld_MA_Items_TBModifiedID = null;
			fld_MA_Items_TBGuid = null;
			fld_MA_Items_DoorsApertura = null;
			fld_MA_Items_DoorsNote = null;
			fld_MA_Items_DoorsLarghezza = null;
			fld_MA_Items_DoorsAltezza = null;
			fld_MA_Items_DoorsFinitura = null;
			fld_MA_Items_DoorsBattuta = null;
			fld_MA_Items_DoorsTipoTelaio = null;
			fld_MA_Items_DoorsSpessore = null;
			fld_MA_Items_DoorsLarghezzaIntBatt = null;
			fld_MA_Items_DoorsAltezzaIntBatt = null;
			fld_MA_Items_DoorsAriaL = null;
			fld_MA_Items_DoorsAriaH = null;
			fld_MA_Items_DoorsSpProfIntTelaio = null;
			fld_MA_Items_DoorsSpProfEstTelaio = null;
		}
	}
}

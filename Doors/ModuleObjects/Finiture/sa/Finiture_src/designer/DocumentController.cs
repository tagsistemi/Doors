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
namespace Customization.Doors.Doors.DynamicDocuments.Finiture.Finiture
{
	public partial class DocumentController : Microarea.EasyBuilder.MVC.DocumentController
	{
		[Microarea.TaskBuilderNet.Core.EasyBuilder.PreserveFieldAttribute]
		private System.IntPtr formHandle;

		[Microarea.TaskBuilderNet.Core.EasyBuilder.PreserveFieldAttribute]
		private System.IntPtr documentHandle;

		[Microarea.TaskBuilderNet.Core.EasyBuilder.PreserveFieldAttribute]
		public new MDFiniture Document
		{
			get
			{
				return (MDFiniture)base.document;
			}
		}

		[Microarea.TaskBuilderNet.Core.EasyBuilder.PreserveFieldAttribute]
		[System.ThreadStaticAttribute]
		public new static DocumentController controller;

		private DocumentController oldController;

		[Microarea.TaskBuilderNet.Core.EasyBuilder.PreserveFieldAttribute]
		public new DocumentView View
		{
			get
			{
				return (DocumentView)base.View;
			}
		}

		public DocumentController(Microarea.TaskBuilderNet.Core.Generic.NameSpace nameSpace, System.IntPtr formHandle, System.IntPtr documentHandle) : base(nameSpace)
		{
			if (controller != null)
				oldController = controller;
			controller = this;
			this.formHandle = formHandle;
			this.documentHandle = documentHandle;
			document_Finiture = new MDFiniture(documentHandle);
			view_Dynamic = new DocumentView(formHandle);
			this.document = document_Finiture;
			this.view = view_Dynamic;
			this.CreateCodeExtender();
		}

		partial void CreateCodeExtender();

		public MDFiniture document_Finiture;

		public DocumentView view_Dynamic;

		public override void CreateComponents()
		{
			this.Add(document_Finiture, true);
			this.Add(view_Dynamic, true);
		}

		public override void ApplyResources()
		{
			Microarea.EasyBuilder.CustomizationComponentResourceManager resources = Strings.ResourceManager;
		}

		public override void ClearComponents()
		{
			base.ClearComponents();
			if (oldController != null)
				controller = oldController;
			oldController = null;
			document_Finiture = null;
			view_Dynamic = null;
		}
	}
}

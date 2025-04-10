//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v13.7.2+fd5b8de
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Oppa13.ContentModels
{
	// Mixin Content Type with alias "garazoBendriPasirinkimai"
	/// <summary>Garažo bendri pasirinkimai</summary>
	public partial interface IGarazoBendriPasirinkimai : IPublishedElement
	{
		/// <summary>Aukstas</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		int Aukstas { get; }

		/// <summary>Numeris</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string Numeris { get; }

		/// <summary>Plotas (m²)</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		decimal PlotasM2 { get; }

		/// <summary>Telpa automobilių</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		int TelpaAutomobiliu { get; }

		/// <summary>Tipas</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string Tipas { get; }

		/// <summary>Vieta automobiliui</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		bool VietaAutomobiliui { get; }

		/// <summary>Visas garažas</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		bool VisasGarazas { get; }
	}

	/// <summary>Garažo bendri pasirinkimai</summary>
	[PublishedModel("garazoBendriPasirinkimai")]
	public partial class GarazoBendriPasirinkimai : PublishedElementModel, IGarazoBendriPasirinkimai
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		public new const string ModelTypeAlias = "garazoBendriPasirinkimai";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<GarazoBendriPasirinkimai, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public GarazoBendriPasirinkimai(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Aukstas
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[ImplementPropertyType("aukstas")]
		public virtual int Aukstas => GetAukstas(this, _publishedValueFallback);

		/// <summary>Static getter for Aukstas</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		public static int GetAukstas(IGarazoBendriPasirinkimai that, IPublishedValueFallback publishedValueFallback) => that.Value<int>(publishedValueFallback, "aukstas");

		///<summary>
		/// Numeris
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("numeris")]
		public virtual string Numeris => GetNumeris(this, _publishedValueFallback);

		/// <summary>Static getter for Numeris</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetNumeris(IGarazoBendriPasirinkimai that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "numeris");

		///<summary>
		/// Plotas (m²)
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[ImplementPropertyType("plotasM2")]
		public virtual decimal PlotasM2 => GetPlotasM2(this, _publishedValueFallback);

		/// <summary>Static getter for Plotas (m²)</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		public static decimal GetPlotasM2(IGarazoBendriPasirinkimai that, IPublishedValueFallback publishedValueFallback) => that.Value<decimal>(publishedValueFallback, "plotasM2");

		///<summary>
		/// Telpa automobilių
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[ImplementPropertyType("telpaAutomobiliu")]
		public virtual int TelpaAutomobiliu => GetTelpaAutomobiliu(this, _publishedValueFallback);

		/// <summary>Static getter for Telpa automobilių</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		public static int GetTelpaAutomobiliu(IGarazoBendriPasirinkimai that, IPublishedValueFallback publishedValueFallback) => that.Value<int>(publishedValueFallback, "telpaAutomobiliu");

		///<summary>
		/// Tipas
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("tipas")]
		public virtual string Tipas => GetTipas(this, _publishedValueFallback);

		/// <summary>Static getter for Tipas</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetTipas(IGarazoBendriPasirinkimai that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "tipas");

		///<summary>
		/// Vieta automobiliui
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[ImplementPropertyType("vietaAutomobiliui")]
		public virtual bool VietaAutomobiliui => GetVietaAutomobiliui(this, _publishedValueFallback);

		/// <summary>Static getter for Vieta automobiliui</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		public static bool GetVietaAutomobiliui(IGarazoBendriPasirinkimai that, IPublishedValueFallback publishedValueFallback) => that.Value<bool>(publishedValueFallback, "vietaAutomobiliui");

		///<summary>
		/// Visas garažas
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[ImplementPropertyType("visasGarazas")]
		public virtual bool VisasGarazas => GetVisasGarazas(this, _publishedValueFallback);

		/// <summary>Static getter for Visas garažas</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		public static bool GetVisasGarazas(IGarazoBendriPasirinkimai that, IPublishedValueFallback publishedValueFallback) => that.Value<bool>(publishedValueFallback, "visasGarazas");
	}
}

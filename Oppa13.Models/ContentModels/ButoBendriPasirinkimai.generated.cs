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
	// Mixin Content Type with alias "butoBendriPasirinkimai"
	/// <summary>Buto bendri pasirinkimai</summary>
	public partial interface IButoBendriPasirinkimai : IPublishedContent
	{
		/// <summary>Aukštas</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		int Aukstas { get; }

		/// <summary>Buto numeris</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string ButoNumeris { get; }

		/// <summary>Įrengimas</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string Irengimas { get; }

		/// <summary>Kambarių skaičius</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		int KambariuSkaicius { get; }

		/// <summary>Namo numeris</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string NamoNumeris { get; }

		/// <summary>Pastato tipas</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		string PastatoTipas { get; }

		/// <summary>Plotas (m2)</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		decimal PlotasM2 { get; }

		/// <summary>Renovacijos metai</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		int RenovacijosMetai { get; }

		/// <summary>Statybos metai</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		int StatybosMetai { get; }

		/// <summary>Viso aukštų</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		int VisoAukstu { get; }
	}

	/// <summary>Buto bendri pasirinkimai</summary>
	[PublishedModel("butoBendriPasirinkimai")]
	public partial class ButoBendriPasirinkimai : PublishedContentModel, IButoBendriPasirinkimai
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		public new const string ModelTypeAlias = "butoBendriPasirinkimai";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<ButoBendriPasirinkimai, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public ButoBendriPasirinkimai(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Aukštas
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[ImplementPropertyType("aukstas")]
		public virtual int Aukstas => GetAukstas(this, _publishedValueFallback);

		/// <summary>Static getter for Aukštas</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		public static int GetAukstas(IButoBendriPasirinkimai that, IPublishedValueFallback publishedValueFallback) => that.Value<int>(publishedValueFallback, "aukstas");

		///<summary>
		/// Buto numeris
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("butoNumeris")]
		public virtual string ButoNumeris => GetButoNumeris(this, _publishedValueFallback);

		/// <summary>Static getter for Buto numeris</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetButoNumeris(IButoBendriPasirinkimai that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "butoNumeris");

		///<summary>
		/// Įrengimas
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("irengimas")]
		public virtual string Irengimas => GetIrengimas(this, _publishedValueFallback);

		/// <summary>Static getter for Įrengimas</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetIrengimas(IButoBendriPasirinkimai that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "irengimas");

		///<summary>
		/// Kambarių skaičius
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[ImplementPropertyType("kambariuSkaicius")]
		public virtual int KambariuSkaicius => GetKambariuSkaicius(this, _publishedValueFallback);

		/// <summary>Static getter for Kambarių skaičius</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		public static int GetKambariuSkaicius(IButoBendriPasirinkimai that, IPublishedValueFallback publishedValueFallback) => that.Value<int>(publishedValueFallback, "kambariuSkaicius");

		///<summary>
		/// Namo numeris
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("namoNumeris")]
		public virtual string NamoNumeris => GetNamoNumeris(this, _publishedValueFallback);

		/// <summary>Static getter for Namo numeris</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetNamoNumeris(IButoBendriPasirinkimai that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "namoNumeris");

		///<summary>
		/// Pastato tipas
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pastatoTipas")]
		public virtual string PastatoTipas => GetPastatoTipas(this, _publishedValueFallback);

		/// <summary>Static getter for Pastato tipas</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static string GetPastatoTipas(IButoBendriPasirinkimai that, IPublishedValueFallback publishedValueFallback) => that.Value<string>(publishedValueFallback, "pastatoTipas");

		///<summary>
		/// Plotas (m2)
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[ImplementPropertyType("plotasM2")]
		public virtual decimal PlotasM2 => GetPlotasM2(this, _publishedValueFallback);

		/// <summary>Static getter for Plotas (m2)</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		public static decimal GetPlotasM2(IButoBendriPasirinkimai that, IPublishedValueFallback publishedValueFallback) => that.Value<decimal>(publishedValueFallback, "plotasM2");

		///<summary>
		/// Renovacijos metai
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[ImplementPropertyType("renovacijosMetai")]
		public virtual int RenovacijosMetai => GetRenovacijosMetai(this, _publishedValueFallback);

		/// <summary>Static getter for Renovacijos metai</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		public static int GetRenovacijosMetai(IButoBendriPasirinkimai that, IPublishedValueFallback publishedValueFallback) => that.Value<int>(publishedValueFallback, "renovacijosMetai");

		///<summary>
		/// Statybos metai
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[ImplementPropertyType("statybosMetai")]
		public virtual int StatybosMetai => GetStatybosMetai(this, _publishedValueFallback);

		/// <summary>Static getter for Statybos metai</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		public static int GetStatybosMetai(IButoBendriPasirinkimai that, IPublishedValueFallback publishedValueFallback) => that.Value<int>(publishedValueFallback, "statybosMetai");

		///<summary>
		/// Viso aukštų
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		[ImplementPropertyType("visoAukstu")]
		public virtual int VisoAukstu => GetVisoAukstu(this, _publishedValueFallback);

		/// <summary>Static getter for Viso aukštų</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "13.7.2+fd5b8de")]
		public static int GetVisoAukstu(IButoBendriPasirinkimai that, IPublishedValueFallback publishedValueFallback) => that.Value<int>(publishedValueFallback, "visoAukstu");
	}
}

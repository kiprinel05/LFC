//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.13.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:/Users/cazan/Desktop/facultate folder/sem3/LFC/LFC/Tema2/MiniCompiler/MiniCompiler/MiniLang.g4 by ANTLR 4.13.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="MiniLangParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.13.1")]
[System.CLSCompliant(false)]
public interface IMiniLangVisitor<Result> : IParseTreeVisitor<Result>
{
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniLangParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] MiniLangParser.ProgramContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniLangParser.function"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunction([NotNull] MiniLangParser.FunctionContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniLangParser.parameterList"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameterList([NotNull] MiniLangParser.ParameterListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniLangParser.parameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParameter([NotNull] MiniLangParser.ParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniLangParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] MiniLangParser.BlockContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniLangParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] MiniLangParser.StatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniLangParser.varDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVarDeclaration([NotNull] MiniLangParser.VarDeclarationContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniLangParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAssignment([NotNull] MiniLangParser.AssignmentContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniLangParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStatement([NotNull] MiniLangParser.IfStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniLangParser.whileStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitWhileStatement([NotNull] MiniLangParser.WhileStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniLangParser.forStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForStatement([NotNull] MiniLangParser.ForStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniLangParser.returnStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitReturnStatement([NotNull] MiniLangParser.ReturnStatementContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Additive</c>
	/// labeled alternative in <see cref="MiniLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitAdditive([NotNull] MiniLangParser.AdditiveContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Multiplicative</c>
	/// labeled alternative in <see cref="MiniLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMultiplicative([NotNull] MiniLangParser.MultiplicativeContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Identifier</c>
	/// labeled alternative in <see cref="MiniLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIdentifier([NotNull] MiniLangParser.IdentifierContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Number</c>
	/// labeled alternative in <see cref="MiniLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumber([NotNull] MiniLangParser.NumberContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Parens</c>
	/// labeled alternative in <see cref="MiniLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitParens([NotNull] MiniLangParser.ParensContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LogicalAnd</c>
	/// labeled alternative in <see cref="MiniLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLogicalAnd([NotNull] MiniLangParser.LogicalAndContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Relational</c>
	/// labeled alternative in <see cref="MiniLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitRelational([NotNull] MiniLangParser.RelationalContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>FunctionCall</c>
	/// labeled alternative in <see cref="MiniLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFunctionCall([NotNull] MiniLangParser.FunctionCallContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>String</c>
	/// labeled alternative in <see cref="MiniLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString([NotNull] MiniLangParser.StringContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>Unary</c>
	/// labeled alternative in <see cref="MiniLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitUnary([NotNull] MiniLangParser.UnaryContext context);
	/// <summary>
	/// Visit a parse tree produced by the <c>LogicalOr</c>
	/// labeled alternative in <see cref="MiniLangParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLogicalOr([NotNull] MiniLangParser.LogicalOrContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="MiniLangParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] MiniLangParser.TypeContext context);
}

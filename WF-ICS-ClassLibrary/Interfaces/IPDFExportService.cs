﻿using System.Collections.Generic;
using WF_ICS_ClassLibrary.Models;

namespace WildfireICSDesktopServices
{
    public interface IPDFExportService
    {
        string createBlankSignInPDF(WFIncident task, List<GroupSignInPrintRequest> groups, int opsPeriod, bool tempFileName = false, bool flattenPDF = false);
        string createBriefingPDF(WFIncident task, Briefing briefing, bool automaticallyOpen = true, bool tempFileName = false);
        string createCommsPlanPDF(WFIncident task, int OpsPeriod, bool automaticallyOpen = true, bool tempFileName = false, bool flattenPDF = false);
        List<byte[]> exportCommsPlanToPDF(WFIncident task, int OpPeriodToExport, bool flattenPDF);
        string createMedicalPlanPDF(WFIncident task, int OpsPeriod, bool automaticallyOpen = true, bool tempFileName = false, bool flattenPDF = false);
        List<byte[]> exportMedicalPlanToPDF(WFIncident task, int OpPeriodToExport, bool flattenPDF);
        string createNotePDF(WFIncident task, Note note, bool automaticallyOpen = true, bool tempFileName = false);
        string createObjectivesPDF(WFIncident task, int OpsPeriod, bool automaticallyOpen = true, bool tempFileName = false, bool flattenPDF = false);
        List<byte[]> exportIncidentObjectivesToPDF(WFIncident task, int OpPeriodToExport, bool flattenPDF);
        List<byte[]> createOpPeriodContentsList(WFIncident task, List<string> items, int OpPeriod);
        string createOrgChartContactList(WFIncident task, int opsPeriod, bool automaticallyOpen = true, bool tempFileName = false);
        List<byte[]> exportOrgChartContactsToPDF(WFIncident task, int OpPeriodToExport);
        string createOrgChartPDF(WFIncident task, int OpsPeriod, bool automaticallyOpen = true, bool tempFileName = false, bool flattenPDF = false);
        List<byte[]> exportOrgChartToPDF(WFIncident task, int OpPeriodToExport, bool flattenPDF);
        string createRadioLogPDF(WFIncident task, int opsPeriod, bool automaticallyOpen = true, bool tempFileName = false);
        string createSafetyMessagePDF(WFIncident task, SafetyMessage plan, bool automaticallyOpen = true, bool tempFileName = false, bool flattenPDF = false);
        string createSignInPDF(WFIncident task, int opsPeriod, bool tempFileName = false, bool flattenPDF = false);
        List<byte[]> createSinglePageBlankSignInSheetAsBytes(WFIncident task, GroupSignInPrintRequest group, int pageNumber, int totalPages, int OpsPeriod, bool flattenPDF = false);
        List<byte[]> createSinglePageSignInSheetAsBytes(WFIncident task, List<MemberStatus> statuses, int pageNumber, int totalPages, int OpsPeriod, bool flattenPDF = false);
        string createTimelinePDF(WFIncident task, bool IncludeSAR, bool IncludeSubject, bool automaticallyOpen = true, bool tempFileName = false);
        List<byte[]> exportBriefingToBytes(int OpPeriodToExport, WFIncident task);
        string exportBriefingToPDF(Briefing briefing, WFIncident task, bool includeExecution, bool includeMapQRImage = false);
        List<byte[]> exportIAPToPDF(WFIncident task, int OpPeriodToExport, bool includeBriefing = true, bool includeSafety = true, bool includeLPQ = true, bool flattenPDF = false);
        List<byte[]> exportNotesToPDF(WFIncident task, int CurrentOpPeriod);
        List<byte[]> exportRadioLogToPDF(WFIncident task, int OpPeriodToExport, bool flattenPDF = false);
        List<byte[]> exportSafetyMessagesToPDF(WFIncident task, int OpPeriodToExport, bool flattenPDF);
        List<byte[]> exportSafetyMessagesToPDF(WFIncident task, List<SafetyMessage> messagesToPrint, bool flattenPDF);
        string createVehiclePDF(WFIncident task, int OpPeriod, string PreparedByName, string PreparedByRoleName, bool useTempPath, bool flattenPDF);
        List<byte[]> exportVehiclesToPDF(WFIncident task, int OpPeriodToExport, string PreparedByName, string PreparedByRoleName, bool flattenPDF);
        string exportSinglePageSignInSheetAsPDF(WFIncident task, List<MemberStatus> statuses, int pageNumber, int totalPages, int OpsPeriod);
        List<byte[]> exportTimelineToPDF(WFIncident task);
        List<byte[]> getBlankSignInSheetPDFs(WFIncident task, List<GroupSignInPrintRequest> groups, int OpsPeriod, bool flattenPDF);
        List<byte[]> getSignInSheetPDFs(WFIncident task, int OpsPeriod, bool flattenPDF);
        List<byte[]> exportGeneralMessagesToPDF(WFIncident task, int OpPeriodToExport, bool flattenPDF);
        List<byte[]> exportGeneralMessagesToPDF(WFIncident task, List<GeneralMessage> items, bool flattenPDF);
        string createGeneralMessagePDF(WFIncident task, GeneralMessage item, bool tempFileName = false, bool flattenPDF = false);
        string createContactsPDF(WFIncident task, int OpPeriod, string createdBy, string createdByTitle, bool useTempPath, bool flattenPDF);
        List<byte[]> exportContactsToPDF(WFIncident task, int OpPeriodToExport, string PreparedByName, string PreparedByRoleName, bool flattenPDF);
        string CreateAirOpsSummaryPDF(WFIncident task, int OpPeriod, bool useTempPath, bool flattenPDF);
        List<byte[]> exportAirOpsSummaryToPDF(WFIncident incident, int OpPeriodToExport, bool flattenPDF = false);
    }
}
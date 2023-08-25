<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:cbc="urn:oasis:names:specification:ubl:schema:xsd:CommonBasicComponents-2"
    xmlns="urn:oasis:names:specification:ubl:schema:xsd:Invoice-2"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
    xsi:schemaLocation="urn:oasis:names:specification:ubl:schema:xsd:Invoice-2 UBL-Invoice-2.1.xsd"
    xmlns:ext="urn:oasis:names:specification:ubl:schema:xsd:CommonExtensionComponents-2"
    xmlns:ds="http://www.w3.org/2000/09/xmldsig#"
    xmlns:xades="http://uri.etsi.org/01903/v1.3.2#"
    xmlns:xsd="http://www.w3.org/2001/XMLSchema"
    xmlns:qdt="urn:oasis:names:specification:ubl:schema:xsd:QualifiedDatatypes-2"
    xmlns:ubltr="urn:oasis:names:specification:ubl:schema:xsd:TurkishCustomizationExtensionComponents"
    xmlns:cac="urn:oasis:names:specification:ubl:schema:xsd:CommonAggregateComponents-2"
    xmlns:udt="urn:un:unece:uncefact:data:specification:UnqualifiedDataTypesSchemaModule:2"
    xmlns:ccts="urn:un:unece:uncefact:documentation:2">

    <xsl:output method="html" indent="yes" omit-xml-declaration="yes"/>

    <xsl:template match="/">
        <html>
            <head>
                <title>Invoice</title>
            </head>
            <body>
                <h1>Invoice</h1>
                <xsl:apply-templates select="Invoice"/>
            </body>
        </html>
    </xsl:template>

    <xsl:template match="Invoice">
        <table border="1">
            <tr>
                <th>ID</th>
                <th>Issue Date</th>
                <th>Document Currency Code</th>
                <!-- Add more fields as needed -->
            </tr>
            <tr>
                <td><xsl:value-of select="cbc:ID"/></td>
                <td><xsl:value-of select="cbc:IssueDate"/></td>
                <td><xsl:value-of select="cbc:DocumentCurrencyCode"/></td>
                <!-- Add more td elements for other fields -->
            </tr>
        </table>
        <!-- You can add more templates to display other parts of the XML -->
    </xsl:template>

</xsl:stylesheet>

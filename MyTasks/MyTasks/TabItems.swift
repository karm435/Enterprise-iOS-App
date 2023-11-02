
import Foundation
import SwiftUI

extension TabItems: Identifiable {
	var id: Self { self }
}

enum TabItems: CaseIterable {
	case tasks, report, settings
	
	var tag: String {
		switch self {
			case .tasks:
				return "tasks"
			case .report:
				return "reports"
			case .settings:
				return "settings"
		}
	}
	
	@ViewBuilder
	var destination: some View {
		switch self {
			case .tasks:
				MyTasksListView()
			case .report:
				ReportsView()
			case .settings:
				SettingsView()
		}
	}
	
	@ViewBuilder
	var tabItem: some View {
		switch self {
			case .tasks:
				Label(
					title: { Text("My Tasks") },
					icon: { Image(systemName: "doc.plaintext") }
				)
			case .report:
				Label {
					Text("Reports")
				} icon: {
					Image(systemName: "chart.bar")
				}
			case .settings:
				Label {
					Text("Settings")
				} icon: {
					Image(systemName: "gear")
				}
		}
	}
}

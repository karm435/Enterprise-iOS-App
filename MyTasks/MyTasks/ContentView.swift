import SwiftUI
import SwiftData

struct ContentView: View {
    var body: some View {
		TabView {
			ForEach(TabItems.allCases) { item in
				item.destination
					.tag(item.tag)
					.tabItem {
						item.tabItem
					}
			}
		}
    }
}

#Preview {
    ContentView()
}
